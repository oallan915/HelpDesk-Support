$sn = (Get-WmiObject win32_bios | select Serialnumber).SerialNumber
$rsize=(Get-Volume -DriveLetter C).SizeRemaining
$diskstatus = (Get-Volume -DriveLetter C).HealthStatus
$OS = Get-WmiObject Win32_OperatingSystem -ErrorAction Stop
$edi = (Get-WmiObject -class Win32_OperatingSystem).Caption.Split("W")[1] 
$sub =Get-ItemPropertyValue 'HKLM:\Software\Microsoft\Windows NT\CurrentVersion' 'UBR'
$gb = "C Drive:    --  " + [math]::Round($rsize/1GB,2) + " GB"
$build = [System.Environment]::OSVersion.Version.Build
$full = ($build.ToString() +"."+$sub)
$edi = "W" + $edi
$edi |Out-File -FilePath C:\temp\edition.txt -force
$full | Out-File -FilePath C:\temp\build.txt -force
$OS.ConvertToDateTime($OS.LastBootUpTime) | Out-File -FilePath C:\temp\LastbootTime.txt -force
$gb |out-file -FilePath C:\Temp\driveFS.txt -Force
$diskstatus |out-file -FilePath C:\Temp\drivehealth.txt -Force
$sn |out-file -filepath C:\Temp\sn.txt -force
(Get-WmiObject -class Win32_OperatingSystem).Caption

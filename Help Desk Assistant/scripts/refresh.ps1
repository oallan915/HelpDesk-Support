$edi = (Get-WmiObject -class Win32_OperatingSystem).Caption.Split("W")[1] 
$sub =Get-ItemPropertyValue 'HKLM:\Software\Microsoft\Windows NT\CurrentVersion' 'UBR'
$build = [System.Environment]::OSVersion.Version.Build
$full = ($build.ToString() +"."+$sub)
$edi = "W" + $edi
$edi |Out-File -FilePath C:\temp\edition.txt -force
$rsize=(Get-Volume -DriveLetter C).SizeRemaining
$diskstatus = (Get-Volume -DriveLetter C).HealthStatus
$gb = "C Drive:    --  " + [math]::Round($rsize/1GB,2) + " GB"
$gb |out-file -FilePath C:\Temp\driveFS.txt -Force
$diskstatus |out-file -FilePath C:\Temp\drivehealth.txt -Force
$rsize=(Get-Volume -DriveLetter C).SizeRemaining
$diskstatus = " - " +(Get-Volume -DriveLetter C).HealthStatus
$gb = "C: -- " + [math]::Round($rsize/1GB,2)
$gb |out-file -FilePath C:\Temp\driveFB.txt -Force
$distatus |out-file -FilePath C:\Temp\drivehealth.txt -Force
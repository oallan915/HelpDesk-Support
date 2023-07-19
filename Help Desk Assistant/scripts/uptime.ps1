  $OS = Get-WmiObject Win32_OperatingSystem -ErrorAction Stop
  $Uptime = (Get-Date) - $OS.ConvertToDateTime($OS.LastBootUpTime)
  ([String]$Uptime.Days + " Days " + $Uptime.Hours + " Hours " + $Uptime.Minutes + " Minutes") | Out-File -FilePath C:\temp\uptime.txt -force
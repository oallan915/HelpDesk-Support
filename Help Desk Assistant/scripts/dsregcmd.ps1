#!/bin/bash
cd C:\Temp
.\dsregcmd.exe /status |out-file -filepath "C:\Temp\Azstatus.txt"


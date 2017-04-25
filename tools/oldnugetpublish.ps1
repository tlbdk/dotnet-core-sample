param([Int32]$nupkgPath="")

$NUGET_SERVER = "http://nuget.danskenet.net/NuGetGallery/api/v2/package"

# Needed for running on TFS
$agentWorkerPath = "$($env:AGENT_HOMEDIRECTORY)\agent\worker"
Import-Module "$agentWorkerPath\Microsoft.TeamFoundation.DistributedTask.Agent.Interfaces.dll"
Import-Module "$agentWorkerPath\Microsoft.TeamFoundation.DistributedTask.Agent.Common.dll"
Import-Module "$agentWorkerPath\Microsoft.TeamFoundation.DistributedTask.Agent.Strings.dll"

$NUGET_PATH = Get-ToolPath -Name 'NuGet.exe';

# Publish
Invoke-Tool -Path $NUGET_PATH -Arguments "push `"$nupkgPath`" -Source $NUGET_SERVER"

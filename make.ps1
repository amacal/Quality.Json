param (
	[Parameter(Position=0,Mandatory=1)] [string] $task
)

function GetCurrentPath {
    Split-Path $script:MyInvocation.MyCommand.Path
}

function GetTempPath {
    (GetCurrentPath) + "\temp"
}

function GetOutputPath {
    (GetCurrentPath) + "\output"
}

function GetBuildPath {
    (GetCurrentPath) + "\build"
}

function GetNuGetPath {
    (GetTempPath) + "\nuget.exe"
}

function CreateTempIfNeeded {
    if ((Test-Path (GetTempPath)) -eq $false) {
        New-Item -Path (GetTempPath) -ItemType Directory | Write-Debug
    }
}

function CreateOutputIfNeeded {
    if ((Test-Path (GetOutputPath)) -eq $false) {
        New-Item -Path (GetOutputPath) -ItemType Directory | Write-Debug
    }
}

function DownloadNuGetIfNeeded {
    CreateTempIfNeeded

    if ((Test-Path (GetNuGetPath)) -eq $false) {
        $file = (GetNuGetPath)
        $url = "https://github.com/psake/psake/blob/master/NuGet.exe?raw=true"
        $client = New-Object System.Net.WebClient
        $client.DownloadFile($url,$file)
    }
}

function ImportMsBuildModuleIfNeeded {
    Import-Module ((GetBuildPath) + "\Invoke-MsBuild.psm1")
}

function RestoreNuGetPackages {
    DownloadNuGetIfNeeded

    & (GetNuGetPath) "restore" ".\src"
}

function BuildBinaries {
    RestoreNuGetPackages
    ImportMsBuildModuleIfNeeded
    CreateOutputIfNeeded

    Invoke-MsBuild -Path ".\src\Solution.2013.Express.sln" `
                   -BuildLogDirectoryPath ((GetTempPath) + "\") `
                   -Params "/target:Clean;Build /property:Configuration=Release;BuildInParallel=true;DebugSymbols=false;OutputPath=$((GetOutputPath) + "\");IntermediateOutputPath=$((GetTempPath) + "\") /verbosity:minimal /maxcpucount"
}

function ExecuteBenchmarks {
    BuildBinaries
    Write-Host

    Set-Location ".\output"
    & ".\Quality.Json.Performance.Runner.exe" -WorkingDirectory
    Set-Location (GetCurrentPath)
}

if ($task -eq "restore-packages") {
    RestoreNuGetPackages
}

elseif ($task -eq "build") {
    BuildBinaries
}

elseif ($task -eq "execute") {
    ExecuteBenchmarks
}
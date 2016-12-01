param(
	[Parameter(Mandatory=$True)]
	[string]$Version,
	[string]$Configuration = "Release",
	[string]$NuGet = $null,
	[string]$VersionSuffix = $null
)

$packageOutputPath = Join-Path $PSScriptRoot "package-output"
if (test-path $packageOutputPath) {
	remove-item -recurse -force $packageOutputPath
}

new-item $packageOutputPath -itemtype directory | out-null

$fullVersion = $Version + (&{if ($VersionSuffix) { "-" + $VersionSuffix } else { "" }})

$nugetExecutable = if ($NuGet) { $NuGet } else { "nuget" }

$nuspecPath = join-path (join-path (Join-Path $PSScriptRoot "src") "Dataline.*") "*.nuspec"

get-item $nuspecPath | % {
	$packageId = $_.Basename
	& $nugetExecutable pack $_.FullName -Properties "Configuration=$Configuration;Id=$packageId" -OutputDirectory $packageOutputPath -Version $fullVersion
	if (!$?) { exit 1 }
}

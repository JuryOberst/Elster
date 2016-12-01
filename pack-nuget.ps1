param(
	[Parameter(Mandatory=$True)]
	[string]$Version,
	[string]$VersionSuffix = $null
)

$packageOutputPath = Join-Path $PSScriptRoot "package-output"
if (test-path $packageOutputPath) {
	remove-item -recurse -force $packageOutputPath
}

new-item $packageOutputPath -itemtype directory | out-null

$fullVersion = $Version + (&{if ($VersionSuffix) { "-" + $VersionSuffix } else { "" }})

$nuspecPath = join-path (join-path (Join-Path $PSScriptRoot "src") "Dataline.*") "*.nuspec"

get-item $nuspecPath | % {
	$packageId = $_.Basename
	& nuget pack $_.FullName -Properties "Configuration=Release;Id=$packageId" -OutputDirectory $packageOutputPath -Version $fullVersion
	if (!$?) { exit 1 }
}

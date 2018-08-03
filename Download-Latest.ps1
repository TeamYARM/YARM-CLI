#
# This downloads the latest yarm-cli release from GitHub.
# Reference: https://gist.github.com/MarkTiedemann/c0adc1701f3f5c215fc2c2d5b1d5efd3
#

Param(
    [string] [Parameter(Mandatory=$false)] $Runtime = "win-x64",
    [string] [Parameter(Mandatory=$false)] $RunPath
)

# Forces TLS 1.2 for GitHub download.
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$repo = "TeamYARM/YARM-CLI"
$releases = "https://api.github.com/repos/$repo/releases"

# Gets the latest release.
Write-Host Checking the latest release
$tag = (Invoke-WebRequest $releases | ConvertFrom-Json)[0].tag_name
$directory = "$tag-$runtime" 
$filename = "$directory.zip"
$download = "https://github.com/$repo/releases/download/$tag/$filename"

# Sets the destination directory
$destination = $directory
if ([string]::IsNullOrWhiteSpace($RunPath) -eq $false) {
    $destination = $RunPath
}

# Downloads the latest release.
Write-Host Dowloading the latest release
Invoke-WebRequest $download -Out $filename

# Unzip the latest release.
Write-Host Extracting release files
Expand-Archive $filename -DestinationPath $destination -Force

# Removes the latest release downloaded.
Write-Host Removing the latest release downloaded
Remove-Item $filename -Force

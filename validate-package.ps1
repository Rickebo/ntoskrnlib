param(
    [string]$PackagePath = "artifacts\ntoskrnlib.0.0.0.nupkg"
)

Write-Host "================================" -ForegroundColor Cyan
Write-Host "NuGet Package Validation" -ForegroundColor Cyan
Write-Host "================================`n" -ForegroundColor Cyan

# Check if package exists
if (-not (Test-Path $PackagePath)) {
    Write-Error "Package not found: $PackagePath"
    exit 1
}

$pkgInfo = Get-Item $PackagePath
Write-Host "Package: $($pkgInfo.Name)"
Write-Host "Size: $([math]::Round($pkgInfo.Length / 1MB, 2)) MB"
Write-Host "Last Modified: $($pkgInfo.LastWriteTime)"
Write-Host ""

# Extract package
$extractPath = "artifacts\extracted-validation"
if (Test-Path $extractPath) {
    Remove-Item $extractPath -Recurse -Force
}

Write-Host "Extracting package..." -ForegroundColor Yellow
$zipPath = "$PackagePath.zip"
Copy-Item $PackagePath $zipPath -Force
Expand-Archive -Path $zipPath -DestinationPath $extractPath -Force
Remove-Item $zipPath -Force

# Find DLL
$dll = Get-ChildItem -Path $extractPath -Recurse -Filter 'ntoskrnlib.dll' | Select-Object -First 1
if (-not $dll) {
    Write-Error "ntoskrnlib.dll not found in package!"
    exit 1
}

$dllSizeKB = [math]::Round($dll.Length / 1KB, 2)
Write-Host "`nDLL Analysis:" -ForegroundColor Green
Write-Host "  Path: $($dll.FullName.Replace($extractPath, ''))"
Write-Host "  Size: $dllSizeKB KB"

# Compare with expected size
$previousSize = 94.5  # The old broken package size
$currentSize = $dllSizeKB

Write-Host "`n  Previous (broken) size: $previousSize KB" -ForegroundColor Red
Write-Host "  Current size: $currentSize KB" -ForegroundColor $(if ($currentSize -gt 200) { "Green" } else { "Yellow" })
Write-Host "  Difference: +$([math]::Round($currentSize - $previousSize, 2)) KB ($([math]::Round((($currentSize - $previousSize) / $previousSize) * 100, 1))% increase)"

# Validation
Write-Host "`nValidation Results:" -ForegroundColor Cyan
if ($currentSize -lt 100) {
    Write-Host "  [FAIL] DLL is too small ($currentSize KB)" -ForegroundColor Red
    Write-Host "    The package likely contains NO generated types" -ForegroundColor Red
    exit 1
} elseif ($currentSize -lt 200) {
    Write-Host "  [WARNING] DLL is small ($currentSize KB)" -ForegroundColor Yellow
    Write-Host "    The package might be missing some generated types" -ForegroundColor Yellow
} else {
    Write-Host "  [PASS] DLL size looks good ($currentSize KB)" -ForegroundColor Green
    Write-Host "    The package appears to contain generated types" -ForegroundColor Green
}

# Count files in package
$csFiles = Get-ChildItem -Path $extractPath -Recurse -Filter "*.cs" -ErrorAction SilentlyContinue
Write-Host "`n  Generated .cs files in package: $($csFiles.Count)" -ForegroundColor Cyan

# Check for dependency DLL
$commonDll = Get-ChildItem -Path $extractPath -Recurse -Filter 'ntoskrnlib.Common.dll' | Select-Object -First 1
if ($commonDll) {
    Write-Host "  [OK] Found ntoskrnlib.Common.dll ($([math]::Round($commonDll.Length / 1KB, 2)) KB)" -ForegroundColor Green
} else {
    Write-Host "  [WARNING] ntoskrnlib.Common.dll not found (might be a dependency reference)" -ForegroundColor Yellow
}

Write-Host "`n================================" -ForegroundColor Cyan
Write-Host "Validation Complete!" -ForegroundColor Cyan
Write-Host "================================`n" -ForegroundColor Cyan

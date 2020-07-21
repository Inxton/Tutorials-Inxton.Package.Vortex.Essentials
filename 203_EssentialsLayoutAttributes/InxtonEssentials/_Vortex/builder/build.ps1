# Find vortex builder
$vortexbuilder = Get-ChildItem -Path ..\packages\ -Recurse -File | Where-Object {$_.Name.Equals("vortex.compiler.console.exe") -and -not $_.Directory.FullName.Contains("app.publish")} | Sort-Object LastCreateTime -Descending | Select-Object -first 1

$vortexbuilder.FullName

& $vortexbuilder.FullName + -r true -v Info -b false
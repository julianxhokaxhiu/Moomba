mkdir ${env:buildPath}\.dist | Out-Null

Set-Location "${env:buildPath}\src\bin\Release\net7.0-windows"
7z a "${env:buildPath}\.dist\${env:_RELEASE_NAME}-${env:_RELEASE_VERSION}_${env:_RELEASE_CONFIGURATION}.zip" ".\*"

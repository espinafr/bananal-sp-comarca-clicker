param(
    [string] $DiretorioSaida = 'dist'
)

$ErrorActionPreference = 'Stop'
$raiz = Split-Path (Split-Path $PSScriptRoot -Parent) -Parent
$projeto = Join-Path $raiz 'crik/crik.csproj'
$saida = [System.IO.Path]::GetFullPath($DiretorioSaida, $raiz)
New-Item -ItemType Directory -Path $saida -Force | Out-Null

$variantes = @(
    @{ Nome = 'minimo'; Autossuficiente = 'false'; Comprimir = 'false' },
    @{ Nome = 'completo'; Autossuficiente = 'true'; Comprimir = 'true' }
)

foreach ($variante in $variantes) {
    # Um diretório novo evita incluir arquivos residuais de outra publicação.
    $temporario = Join-Path ([System.IO.Path]::GetTempPath()) ('bananal-' + [guid]::NewGuid())
    $argumentos = @(
        'publish', $projeto,
        '--configuration', 'Release',
        '--runtime', 'win-x64',
        '--self-contained', $variante.Autossuficiente,
        '--output', $temporario,
        '-p:PublishSingleFile=true',
        '-p:IncludeNativeLibrariesForSelfExtract=true',
        "-p:EnableCompressionInSingleFile=$($variante.Comprimir)",
        '-p:PublishReadyToRun=false',
        '-p:PublishTrimmed=false',
        '-p:DebugType=none',
        '-p:DebugSymbols=false'
    )

    & dotnet @argumentos
    if ($LASTEXITCODE -ne 0) { throw "Falha ao publicar a versão $($variante.Nome)." }

    $executavel = Join-Path $temporario 'crik.exe'
    if (!(Test-Path -LiteralPath $executavel)) { throw 'Executável não encontrado.' }
    $extras = @(Get-ChildItem -LiteralPath $temporario -Recurse -File |
        Where-Object { $_.FullName -ne $executavel })
    if ($extras.Count -gt 0) {
        throw "A publicação gerou arquivos externos ao executável: $($extras.Name -join ', ')."
    }

    $destino = Join-Path $saida "bananal-$($variante.Nome)-win-x64.exe"
    Copy-Item -LiteralPath $executavel -Destination $destino -Force
    $tamanho = (Get-Item -LiteralPath $destino).Length / 1MB
    Write-Host ("Versão {0}: {1:N2} MiB" -f $variante.Nome, $tamanho)
}

$hashes = foreach ($variante in $variantes) {
    $nome = "bananal-$($variante.Nome)-win-x64.exe"
    $hash = (Get-FileHash -LiteralPath (Join-Path $saida $nome) -Algorithm SHA256).Hash.ToLowerInvariant()
    "$hash  $nome"
}
$hashes | Set-Content -LiteralPath (Join-Path $saida 'SHA256SUMS.txt') -Encoding ascii

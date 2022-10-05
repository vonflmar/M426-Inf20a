# .NET-Framework 6 installieren

## Windows 10

Befolgen Sie die Anweisungen der [offiziellen
Anleitung](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=net50):

1. Laden Sie sich den [Installer](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) für das .NET-Framework herunter.
2. Führen Sie die Installationsroutine mit den Standardeinstellungen durch.

Öffnen Sie eine PowerShell und führen Sie den folgenden Befehl aus:

```powershell
dotnet --list-sdks
```

Es sollte Eine Versionsnummer der Form `6.x.y` ausgegeben werden.

# Tests ausführen

Wechseln Sie ins Arbeitsverzeichnis des geklonten Git-Repositories und führen
Sie folgenden Befehl aus:

```bash
dotnet test
```

Dies kann bei der ersten Ausführung einige Minuten lang dauern. Anschliessend
sollte eine grüne Erfolgsmeldung (`Passed!` bzw. `Bestanden!`) ausgegeben
werden.

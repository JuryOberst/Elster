# ELSTER

Dieses Repository enthält diverse Hilfsfunktionen, wie z.B.:

* Überprüfung der eTIN
* Überprüfung der Steueridentifikationsnummer
* Überprüfung der Steuernummer
* Statische Liste aller Finanzämter (von 2007 an)

Über das [Entwickler-Portal von ELSTER](https://www.elster.de/ssl/secure/schnittstellen_herst.php)
sind XML-Schema-Dateien herunterladbar, die für die Validierung genutzt werden können, wenn
man **nicht** ERiC verwenden möchte. Aus diesen Schema-Dateien wurden mithilfe des
[xsd-Tools von Microsoft]() .NET-Klassen erstellt. Alle Projekte sind ebenfalls als NuGet-Paket
verfügbar.

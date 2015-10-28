# ELSTER

[![TeamCity-Status](http://build.service-dataline.de:8081/app/rest/builds/buildType:(id:Elster_ReleaseBuild)/statusIcon)](https://build.service-dataline.de:8081/viewType.html?buildTypeId=Elster_ReleaseBuild)

Dieses Repository enthält diverse Hilfsfunktionen, wie z.B.:

* Überprüfung der eTIN
* Überprüfung der Steueridentifikationsnummer
* Überprüfung der Steuernummer
* Statische Liste aller Finanzämter (von 2007 an)

Über das [Entwickler-Portal von ELSTER](https://www.elster.de/ssl/secure/schnittstellen_herst.php)
sind XML-Schema-Dateien herunterladbar, die für die Validierung genutzt werden können, wenn
man **nicht** ERiC verwenden möchte. Aus diesen Schema-Dateien wurden mithilfe des
[xsd-Tools von Microsoft](https://msdn.microsoft.com/de-de/library/x6c1kb0s.aspx) .NET-Klassen
erstellt. Alle Projekte sind ebenfalls als NuGet-Paket verfügbar.

* [![Dataline.Elster](https://img.shields.io/nuget/v/Dataline.Elster.svg])](https://www.nuget.org/packages/Dataline.Elster/)
* [![Dataline.Elster.Basis](https://img.shields.io/nuget/v/Dataline.Elster.Basis.svg])](https://www.nuget.org/packages/Dataline.Elster.Basis/)
* [![Dataline.Elster.Anmeldung](https://img.shields.io/nuget/v/Dataline.Elster.Anmeldung.svg])](https://www.nuget.org/packages/Dataline.Elster.Anmeldung/)
* [![Dataline.Elster.Datenabholung](https://img.shields.io/nuget/v/Dataline.Elster.Datenabholung.svg])](https://www.nuget.org/packages/Dataline.Elster.Datenabholung/)
* [![Dataline.Elster.Datenuebermittler2015](https://img.shields.io/nuget/v/Dataline.Elster.Datenuebermittler2015.svg])](https://www.nuget.org/packages/Dataline.Elster.Datenuebermittler2015/)
* [![Dataline.Elster.Lohn](https://img.shields.io/nuget/v/Dataline.Elster.Lohn.svg])](https://www.nuget.org/packages/Dataline.Elster.Lohn/)

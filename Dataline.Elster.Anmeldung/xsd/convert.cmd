@echo off

md ..\Lohnsteuer200401
md ..\Lohnsteuer200501
md ..\Lohnsteuer200601
md ..\Lohnsteuer200701
md ..\Lohnsteuer200801
md ..\Lohnsteuer200901
md ..\Lohnsteuer201001
md ..\Lohnsteuer201101
md ..\Lohnsteuer201201
md ..\Lohnsteuer201301
md ..\Lohnsteuer201401
md ..\Lohnsteuer201501
md ..\Umsatzsteuer200401
md ..\Umsatzsteuer200501
md ..\Umsatzsteuer200601
md ..\Umsatzsteuer200701
md ..\Umsatzsteuer200801
md ..\Umsatzsteuer200901
md ..\Umsatzsteuer201001
md ..\Umsatzsteuer201101
md ..\Umsatzsteuer201102
md ..\Umsatzsteuer201201
md ..\Umsatzsteuer201301
md ..\Umsatzsteuer201401
md ..\Umsatzsteuer201501

xsd /o:..\Lohnsteuer200401 /n:Dataline.Elster.Anmeldung.Lohnsteuer200401 /edb /c headerbasis000002.xsd .\elster0810_LStA_200401_extern.xsd
xsd /o:..\Lohnsteuer200501 /n:Dataline.Elster.Anmeldung.Lohnsteuer200501 /edb /c headerbasis000002.xsd .\elster0810_LStA_200501_extern.xsd
xsd /o:..\Lohnsteuer200601 /n:Dataline.Elster.Anmeldung.Lohnsteuer200601 /edb /c headerbasis000002.xsd .\elster0810_LStA_200601_extern.xsd
xsd /o:..\Lohnsteuer200701 /n:Dataline.Elster.Anmeldung.Lohnsteuer200701 /edb /c headerbasis000002.xsd .\elster0810_LStA_200701_extern.xsd
xsd /o:..\Lohnsteuer200801 /n:Dataline.Elster.Anmeldung.Lohnsteuer200801 /edb /c headerbasis000002.xsd .\elster0810_LStA_200801_extern.xsd
xsd /o:..\Lohnsteuer200901 /n:Dataline.Elster.Anmeldung.Lohnsteuer200901 /edb /c headerbasis000002.xsd .\elster0810_LStA_200901_extern.xsd
xsd /o:..\Lohnsteuer201001 /n:Dataline.Elster.Anmeldung.Lohnsteuer200101 /edb /c headerbasis000002.xsd .\elster0810_LStA_201001_extern.xsd
xsd /o:..\Lohnsteuer201101 /n:Dataline.Elster.Anmeldung.Lohnsteuer200111 /edb /c headerbasis000002.xsd .\elster0810_LStA_201101_extern.xsd
xsd /o:..\Lohnsteuer201201 /n:Dataline.Elster.Anmeldung.Lohnsteuer200121 /edb /c headerbasis000002.xsd .\elster0810_LStA_201201_extern.xsd
xsd /o:..\Lohnsteuer201301 /n:Dataline.Elster.Anmeldung.Lohnsteuer200131 /edb /c headerbasis000002.xsd .\elster0810_LStA_201301_extern.xsd
xsd /o:..\Lohnsteuer201401 /n:Dataline.Elster.Anmeldung.Lohnsteuer200141 /edb /c headerbasis000002.xsd .\elster0810_LStA_201401_extern.xsd
xsd /o:..\Lohnsteuer201501 /n:Dataline.Elster.Anmeldung.Lohnsteuer200151 /edb /c headerbasis000002.xsd .\elster0810_LStA_201501_extern.xsd
xsd /o:..\Umsatzsteuer200401 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200401 /edb /c headerbasis000002.xsd .\elster0810_UStA_200401_extern.xsd
xsd /o:..\Umsatzsteuer200501 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200501 /edb /c headerbasis000002.xsd .\elster0810_UStA_200501_extern.xsd
xsd /o:..\Umsatzsteuer200601 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200601 /edb /c headerbasis000002.xsd .\elster0810_UStA_200601_extern.xsd
xsd /o:..\Umsatzsteuer200701 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200701 /edb /c headerbasis000002.xsd .\elster0810_UStA_200701_extern.xsd
xsd /o:..\Umsatzsteuer200801 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200801 /edb /c headerbasis000002.xsd .\elster0810_UStA_200801_extern.xsd
xsd /o:..\Umsatzsteuer200901 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200901 /edb /c headerbasis000002.xsd .\elster0810_UStA_200901_extern.xsd
xsd /o:..\Umsatzsteuer201001 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200101 /edb /c headerbasis000002.xsd .\elster0810_UStA_201001_extern.xsd
xsd /o:..\Umsatzsteuer201101 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200111 /edb /c headerbasis000002.xsd .\elster0810_UStA_201101_extern.xsd
xsd /o:..\Umsatzsteuer201102 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200112 /edb /c headerbasis000002.xsd .\elster0810_UStA_201102_extern.xsd
xsd /o:..\Umsatzsteuer201201 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200121 /edb /c headerbasis000002.xsd .\elster0810_UStA_201201_extern.xsd
xsd /o:..\Umsatzsteuer201301 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200131 /edb /c headerbasis000002.xsd .\elster0810_UStA_201301_extern.xsd
xsd /o:..\Umsatzsteuer201401 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200141 /edb /c headerbasis000002.xsd .\elster0810_UStA_201401_extern.xsd
xsd /o:..\Umsatzsteuer201501 /n:Dataline.Elster.Anmeldung.Umsatzsteuer200151 /edb /c headerbasis000002.xsd .\elster0810_UStA_201501_extern.xsd

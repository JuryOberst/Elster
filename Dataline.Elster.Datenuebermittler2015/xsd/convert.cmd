@echo off
xsd /o:.. /n:Dataline.Elster.Datenuebermittler2015 /edb /c headerbasis000002.xsd datenuebermittler-2015\SimpleTypes-2015.xsd datenuebermittler-2015\ArbeitnehmerAnmeldenRequest-2015.xsd datenuebermittler-2015\DatenuebermittlerWechselRequest-2015.xsd datenuebermittler-2015\ArbeitnehmerAbmeldenRequest-2015.xsd .\elster0810_elo2_extern-2015.xsd 
xsd /o:.. /n:Dataline.Elster.Datenuebermittler2015 /edb /c headerbasis000002.xsd datenuebermittler-2015\SimpleTypes-2015.xsd .\datenuebermittler-2015\Aenderungsliste-2015.xsd

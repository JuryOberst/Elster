﻿
using Dataline.Elster.Basis;

namespace Dataline.Elster.Anmeldung.LStA201101
{
    public partial class AnmeldungssteuernCType : IAnmeldungssteuern
    {
        string IAnmeldungssteuern.DatensatzVersion
        {
            get { return XmlSchemaUtilities.GetEnumXmlValue(version); }
        }
    }
}

﻿using Dataline.Elster.Basis;

namespace Dataline.Elster.Anmeldung.UStA201102
{
    public partial class usta_AnmeldungssteuernCType : IAnmeldungssteuern
    {
        string IAnmeldungssteuern.DatensatzVersion
        {
            get { return XmlSchemaUtilities.GetEnumXmlValue(version); }
        }
    }
}
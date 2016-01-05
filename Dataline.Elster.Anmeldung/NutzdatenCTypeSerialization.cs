using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using JetBrains.Annotations;

namespace Dataline.Elster.Anmeldung
{
    public partial class NutzdatenCType : IXmlSerializable
    {
        private static readonly XNamespace ElsterNamespace = XNamespace.Get("http://www.elster.de/2002/XMLSchema");

        private static readonly Dictionary<Type, XmlSerializer> _serializers = new Dictionary<Type, XmlSerializer>();

        System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
        {
            return null;
        }

        void IXmlSerializable.ReadXml(System.Xml.XmlReader reader)
        {
            var element = (XElement)XNode.ReadFrom(reader);
            var anmeldungssteuern = element.Element(ElsterNamespace + "Anmeldungssteuern");
            if (anmeldungssteuern == null)
                throw new XmlException("Der Knoten \'Anmeldungssteuern\' fehlt unterhalb von \'Nutzdaten\'.");
            var version = anmeldungssteuern.Attribute("version");
            var art = anmeldungssteuern.Attribute("art");
            var artNamespace = (art.Value == "LStA" ? art.Value : "UStA");
            var artClassName = (art.Value == "LStA" ? "AnmeldungssteuernCType" : "usta_AnmeldungssteuernCType");
            var targetTypeName = string.Format("{3}.{1}{0}.{2}", version, artNamespace, artClassName, typeof(NutzdatenCType).Namespace);
            var targetType = Type.GetType(targetTypeName, true);

            var serializer = GetSerializer(targetType);
            Anmeldungssteuern = (IAnmeldungssteuern)serializer.Deserialize(anmeldungssteuern.CreateReader());
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            var serializer = GetSerializer(Anmeldungssteuern.GetType());
            serializer.Serialize(writer, Anmeldungssteuern);
        }

        private static XmlSerializer GetSerializer([NotNull] Type t)
        {
            lock (_serializers)
            {
                XmlSerializer serializer;
                if (!_serializers.TryGetValue(t, out serializer))
                {
                    var rootAttr = new XmlRootAttribute("Anmeldungssteuern")
                    {
                        Namespace = ElsterNamespace.NamespaceName,
                    };
                    serializer = new XmlSerializer(t, rootAttr);
                    _serializers.Add(t, serializer);
                }
                return serializer;
            }
        }
    }
}

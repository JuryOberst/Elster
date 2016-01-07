using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

using Dataline.Elster.Basis;

using JetBrains.Annotations;

using Xunit;

namespace Dataline.Elster.Test
{
    public abstract class ElsterDocumentValidation
    {
        private static readonly XNamespace Xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");


        protected void TestDocument(XDocument doc, IResourceProvider provider, string baseFileName, bool forceSettingSchemaLocation = false)
        {
            doc = FixDocumentSchema(doc, baseFileName, forceSettingSchemaLocation);

            var resolver = new ResourceProviderXmlResolver(new Uri(ResourceProviderXmlResolver.TestRootUri, "Schemata/"), provider);
            var readerSettings = new XmlReaderSettings()
            {
                CheckCharacters = true,
                CloseInput = true,
                ValidationType = ValidationType.Schema,
                ValidationFlags = XmlSchemaValidationFlags.AllowXmlAttributes | XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.ProcessSchemaLocation,
                XmlResolver = resolver,
            };

            var output = new MemoryStream();
            doc.Save(output, SaveOptions.DisableFormatting | SaveOptions.OmitDuplicateNamespaces);
            output.Position = 0;
            using (var validator = XmlReader.Create(output, readerSettings, new Uri(ResourceProviderXmlResolver.TestRootUri, "test.xml").ToString()))
            {
                while (validator.Read())
                {
                    // Nichts machen
                }
            }

            Assert.True(resolver.EntityFetched);
        }

        private static XDocument FixDocumentSchema(XDocument document, string baseFileName, bool forceSettingSchemaLocation)
        {
            var docRoot = document.Root;
            if (docRoot == null)
                return document;

            var documentChanged = false;
            if (docRoot.Attribute(XNamespace.Xmlns + "xsi") == null)
            {
                docRoot.SetAttributeValue(XNamespace.Xmlns + "xsi", Xsi.NamespaceName);
                documentChanged = true;
            }
            var schemaLocationAttribute = docRoot.Attribute(Xsi + "schemaLocation");
            if (forceSettingSchemaLocation)
            {
                schemaLocationAttribute?.Remove();
            }
            if (forceSettingSchemaLocation || schemaLocationAttribute == null)
            {
                Assert.NotNull(document.Root);
                //var docSchema = document.Root.Name.NamespaceName;
                //if (string.IsNullOrEmpty(docSchema))
                //    docSchema = "http://www.elster.de/2002/XMLSchema";
                var docSchema = "http://www.elster.de/2002/XMLSchema";
                var schemaLocation = $"{docSchema} ./Schemata/{baseFileName.Replace("\\", "/")}";
                docRoot.SetAttributeValue(Xsi + "schemaLocation", schemaLocation);
                documentChanged = true;
            }
            return documentChanged ? CopyXmlDocument(document) : document;
        }

        private static XDocument CopyXmlDocument(XDocument document)
        {
            using (var output = new MemoryStream())
            {
                document.Save(output);
                output.Seek(0, SeekOrigin.Begin);

                var result = XDocument.Load(output);

                return result;
            }
        }
    }
}

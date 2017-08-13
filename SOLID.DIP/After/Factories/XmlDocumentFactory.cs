using System.Xml;
using SOLID.DIP.After.Factories.Interfaces;

namespace SOLID.DIP.After.Factories
{
    public class XmlDocumentFactory : IXmlDocumentFactory
    {
        public XmlDocument Create(string fileName)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            return xmlDocument;
        }
    }
}

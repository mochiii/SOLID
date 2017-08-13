using System.Xml;

namespace SOLID.DIP.After.Factories.Interfaces
{
    public interface IXmlDocumentFactory
    {
        XmlDocument Create(string fileName);
    }
}
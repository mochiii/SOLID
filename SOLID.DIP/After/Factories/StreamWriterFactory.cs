using System.IO;
using SOLID.DIP.After.Factories.Interfaces;

namespace SOLID.DIP.After.Factories
{
    public class StreamWriterFactory : IStreamWriterFactory
    {
        public StreamWriter Create(string path) => new StreamWriter(path);
    }
}

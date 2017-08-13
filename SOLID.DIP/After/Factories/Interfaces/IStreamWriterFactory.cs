using System.IO;

namespace SOLID.DIP.After.Factories.Interfaces
{
    public interface IStreamWriterFactory
    {
        StreamWriter Create(string path);
    }
}
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Prototype.Cloneable;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this T self)
    {
        var stream = new MemoryStream();
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, self);
        stream.Seek(0, SeekOrigin.Begin);
        var copy = formatter.Deserialize(stream);
        stream.Close();
        return (T)copy;
    }

    public static T DeepCopyXml<T>(this T self)
    {
        using var ms = new MemoryStream();
        var s = new XmlSerializer(typeof(T));
        s.Serialize(ms, self);
        ms.Position = 0;
        return (T)s.Deserialize(ms);
    }
}
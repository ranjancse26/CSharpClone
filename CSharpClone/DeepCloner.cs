using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpClone
{
    public static class DeepCloner
    {
        // Return a deep clone of an object of type T.
        public static T DeepClone<T>(this T obj)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Serialize the object into the memory stream.
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, obj);

                // Rewind the stream and use it to create a new object.
                memoryStream.Position = 0;
                return (T)formatter.Deserialize(memoryStream);
            }
        }
    }
}

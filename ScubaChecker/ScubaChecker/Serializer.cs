using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class Serializer<T> : ISerializer<T>
    {
        public Stream Serialize(T[] testsToSerialize)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, testsToSerialize);
            return stream;
        }
    }
}

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
            //MemoryStream stream = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(testsToSerialize.GetType());
            StreamWriter streamWriter = new StreamWriter(@"C:\Code\ScubaChecker\files\Serialization.xml");
            serializer.Serialize(streamWriter, testsToSerialize);
            streamWriter.Dispose();
            FileStream fileStream = File.OpenRead(@"C:\Code\ScubaChecker\files\Serialization.xml");
            return fileStream;
        }
    }
}

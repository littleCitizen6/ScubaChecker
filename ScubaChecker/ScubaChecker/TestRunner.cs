using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ScubaChecker
{
    public class TestRunner<T> : ITestsRunner<T>
    {
        public T[] Deserialize(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            return (T[])serializer.Deserialize(stream);
        }
    }
}

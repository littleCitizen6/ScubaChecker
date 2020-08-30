using System;

namespace ScubaChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase[] tests = new TestCase[2];
            tests[0] = new TestCase();
            tests[0].Id = 1111;
            tests[1] = new TestCase();
            tests[1].Id = 2222;
            var factory = new SerializerFactory();
            var serializer = factory.CreateSerializer<TestCase>();
            var stream = serializer.Serialize(tests);
            var deserializer = factory.CreateDeserializer<TestCase>();
            var tests2 = deserializer.Deserialize(stream);
            for (int i = 0; i < 2; i++)
            {
                if(tests[i].Id == tests2[i].Id)
                    Console.WriteLine("should see twice");
            }
            stream.Dispose();
        }
    }
}

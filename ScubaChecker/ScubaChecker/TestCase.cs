using MamasChecker.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScubaChecker
{
    [Serializable]
    public class TestCase : ITestCase
    {
        public string TestContent { get ; set ; }
        public int Id { get; set; }

        public bool Run()
        {
            return true;
        }
    }
}

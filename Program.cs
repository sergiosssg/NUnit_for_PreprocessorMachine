
using System;
using NUnit.Framework;

namespace NUnit_for_PreprocessorMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    [TestFixture]
    public class ActionInRuleTest
    {
        [Test]
        public bool OneActionRuleWithLabelAddedSuccessfully()
        {

            return false;
        }
    }
}

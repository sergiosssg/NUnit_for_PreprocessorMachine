
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

    [TestFixture]
    public class LabelOfProcessingTest
    {

        [Test]
        public bool StringLabelGetting()
        {

            return false;
        }

        [Test]
        public bool LongLabelGetting()
        {

            return false;
        }

        [Test]
        public bool IntLabelGetting()
        {

            return false;
        }

        [Test]
        public bool DecimalLabelGetting()
        {

            return false;
        }

        [Test]
        public bool DateTimeLabelGetting()
        {

            return false;
        }

        [Test]
        public bool BoolLabelGetting()
        {

            return false;
        }

        [Test]
        public bool ComboLogicLabelGetting()
        {

            return false;
        }



    }
}

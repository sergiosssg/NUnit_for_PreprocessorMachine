
using System;
using NUnit.Framework;
using PM;


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
    public class ComparisonOperatorTypeTest
    {

        [Test]
        public bool LEcomparisionTest()
        {
            return false;
        }

        [Test]
        public bool LTcomparisionTest()
        {
            return false;
        }


        [Test]
        public bool GEcomparisionTest()
        {
            return false;
        }

        [Test]
        public bool GTcomparisionTest()
        {
            return false;
        }

        [Test]
        public bool EQcomparisionTest()
        {
            return false;
        }

        [Test]
        public bool NEcomparisionTest()
        {
            return false;
        }

        [Test]
        public bool CONTAINScomparisionTest()
        {
            return false;
        }

        [Test]
        public bool NOTCONTAINScomparisionTest()
        {
            return false;
        }

    }


    [TestFixture]
    public class ActionInRuleTest
    {
        [Test]
        public bool OneActionRuleWithLabelAddedSuccessfully()
        {
            ActionInRule actionRule = new ActionInRule();

           


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

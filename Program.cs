
using System;
using NUnit.Framework;
using PM;


namespace NUnit_for_PreprocessorMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test passed!");
        }
    }


    [TestFixture]
    public class ComparisonOperatorTypeTests
    {




        [TestCase(OperandType.BOOL, ComparisonOperatorType.EQ, "true", true, typeof(bool))]
        [TestCase(OperandType.DATE, ComparisonOperatorType.EQ, "2012/12/12 12/12")]
        [TestCase(OperandType.DECIMAL, ComparisonOperatorType.EQ, "2.2")]
        [TestCase(OperandType.INT, ComparisonOperatorType.EQ, "2")]
        [TestCase(OperandType.LONG, ComparisonOperatorType.EQ, "2")]
        [TestCase(OperandType.STRING, ComparisonOperatorType.EQ, "two")]
        [TestCase(OperandType.BOOL, ComparisonOperatorType.EQ)]
        [Category ("Fastest Tests")]
        public static bool  ComparissionOfOperandtype_TestingPassed_exeptComboLogic_and_exeptFuzzyLogic(OperandType operandType, 
            ComparisonOperatorType comparisonOperatorType, 
            string sRawValue, 
            object etalonValue,
            Type etalonType)
        {
            return true;
        }



    }


    [TestFixture]
    public class OperandTypeTests
    {
        [Test]
        public bool OperandType_INT_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_INT_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_INT_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_INT_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_INT_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_INT_GreaterOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_LONG_GreaterOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DECIMAL_GreaterOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_STRING_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_STRING_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_STRING_Contains()
        {
            return true;
        }

        [Test]
        public bool OperandType_STRING_NotContains()
        {
            return true;
        }

        [Test]
        public bool OperandType_BOOL_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_BOOL_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_DATE_GreaterOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_FUZZY_GreaterOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_Equal()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_NotEqual()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_GreaterThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_LessThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_LessOrEqualThen()
        {
            return true;
        }

        [Test]
        public bool OperandType_COMBYLOGIC_GreaterOrEqualThen()
        {
            return true;
        }

    }


    [TestFixture]
    public class ActionInRuleTests
    {
        [Test]
        public bool OneActionRuleWithLabelAddedSuccessfully()
        {
            IActionRule actionRule = new LabelActionInRule();

           


            return true;
        }
    }

    [TestFixture]
    public class LabelOfProcessingTests
    {

        [Test]
        public bool StringLabelGetting()
        {

            return true;
        }

        [Test]
        public bool LongLabelGetting()
        {

            return true;
        }

        [Test]
        public bool IntLabelGetting()
        {

            return true;
        }

        [Test]
        public bool DecimalLabelGetting()
        {

            return true;
        }

        [Test]
        public bool DateTimeLabelGetting()
        {

            return true;
        }

        [Test]
        public bool BoolLabelGetting()
        {

            return true;
        }

        [Test]
        public bool ComboLogicLabelGetting()
        {

            return true;
        }



    }
}

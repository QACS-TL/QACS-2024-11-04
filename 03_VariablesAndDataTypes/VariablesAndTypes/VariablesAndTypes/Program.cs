namespace VariablesAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            DataTypes.BoolDataTypes();
            DataTypes.CharDataTypes();
            DataTypes.NullableDataTypes();
            DataTypes.StructDataTypes();
            DataTypes.EnumDataTypes();


            //Reference Types
            DataTypes.StringDataTypes();
            DataTypes.ClassDataTypes();

            //Creating Simple Types
            DataTypes.CreatingSimpleTypes();
            DataTypes.CreatingNonSimpleTypes();
            DataTypes.CreatingReferenceTypes();

            //Arithmetic Operators
            DataTypes.ArithmeticPreAndPostFixOperatorExamples();
            DataTypes.UnaryOperatorExamples();
            DataTypes.AddAndSubtractOperatorExamples();
            DataTypes.MultiplyAndDivideOperatorExamples();
            DataTypes.RemainderOperatorExamples();
            DataTypes.OperatorPrecedence();

            //Comparisons
            DataTypes.ComparisonOperators();
            DataTypes.LogicalOperators();
            DataTypes.LogicalOperators2();
            DataTypes.LogicalOperators3();

            //Bitwise and Shift Operators
            DataTypes.BitwiseAndShiftOperators1();
            DataTypes.BitwiseAndShiftOperators2();

            //Equality Operators
            DataTypes.EqualityOperators1();
            DataTypes.EqualityOperators2();

            //Parse
            DataTypes.Parsing();
            DataTypes.IntegralConversions();
        }
    }
}
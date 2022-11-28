namespace ThirdExercise
{
    public class Substraction : Operation
    {
        public Substraction(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
        public override void Operate() =>
            Console.WriteLine("Resultado de resta: {0}", Value1 - Value2);
    }
}

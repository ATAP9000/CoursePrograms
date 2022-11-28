namespace ThirdExercise
{
    public class Sum : Operation
    {
        public Sum(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public override void Operate() =>
            Console.WriteLine("Resultado de suma: {0}",Value1 + Value2);
    }
}

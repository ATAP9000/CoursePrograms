namespace ThirdExercise
{
    public abstract class Operation
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public abstract void Operate();
    }
}

namespace PublishNugetTester
{
    public interface IArithmetic<T>
    {
        T Addition(T left, T right);
        T Subtraction(T left, T right);
        T Multiplication(T left, T right);
        T Division(T left, T right);
    }
}

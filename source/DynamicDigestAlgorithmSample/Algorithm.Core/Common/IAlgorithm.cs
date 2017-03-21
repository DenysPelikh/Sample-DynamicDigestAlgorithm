namespace Algorithm.Core.Common
{
    public interface IAlgorithm<in T>
    {
        AlgorithmResult Handle(T value);
    }
}

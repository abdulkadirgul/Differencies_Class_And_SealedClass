


using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<BenchmarkTest>();
public class BenchmarkTest
{
    private readonly NoneSealedClass _noneSealedClass = new();
    private readonly SealedClass _sealedClass = new();

    [Benchmark]
    public int NoneSealedClassBencmark()
    {
        return _noneSealedClass.Calculate(5, 7);
    }

    [Benchmark]
    public int SealedClassBencmark()
    {
        return _sealedClass.Calculate(5, 7);
    }
}


public sealed class SealedClass   //İnheritance alınamaz, Virtual Kullanılamaz  *DEVİRTUALİZATİON VARDIR*
{
    public int Calculate (int x,int y)
    {
        return x * y;
    }
}

public class NoneSealedClass
{
    public virtual int Calculate(int x,int y)
    {
        return x * y;
    }
}
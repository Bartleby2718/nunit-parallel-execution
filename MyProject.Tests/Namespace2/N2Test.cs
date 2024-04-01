namespace Namespace2;

[SetUpFixture, Parallelizable]
public class Namespace2SetUpFixture
{
    [OneTimeSetUp]
    public async Task N2OneTimeSetUp()
    {
        TestContext.Progress.WriteLine($"{nameof(N2OneTimeSetUp)}: Starting at {DateTime.Now}");
        await Task.Delay(TimeSpan.FromSeconds(10));
        TestContext.Progress.WriteLine($"{nameof(N2OneTimeSetUp)}: Finishing at {DateTime.Now}");
    }
}

[Parallelizable]
public class N2Test
{
    [Test]
    public async Task N2SlowTest1()
    {
        TestContext.Progress.WriteLine($"{nameof(N2SlowTest1)}: Starting at {DateTime.Now}");
        await Task.Delay(TimeSpan.FromSeconds(10));
        TestContext.Progress.WriteLine($"{nameof(N2SlowTest1)}: Finishing at {DateTime.Now}");
    }
}

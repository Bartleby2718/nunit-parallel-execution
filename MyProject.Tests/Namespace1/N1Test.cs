namespace Namespace1;

[SetUpFixture, Parallelizable]
public class Namespace1SetUpFixture
{
    [OneTimeSetUp]
    public async Task N1OneTimeSetUp()
    {
        TestContext.Progress.WriteLine($"{nameof(N1OneTimeSetUp)}: Starting at {DateTime.Now}");
        await Task.Delay(TimeSpan.FromSeconds(10));
        TestContext.Progress.WriteLine($"{nameof(N1OneTimeSetUp)}: Finishing at {DateTime.Now}");
    }
}

[Parallelizable]
public class N1Test
{
    [Test]
    public async Task N1SlowTest1()
    {
        TestContext.Progress.WriteLine($"{nameof(N1SlowTest1)}: Starting at {DateTime.Now}");
        await Task.Delay(TimeSpan.FromSeconds(10));
        TestContext.Progress.WriteLine($"{nameof(N1SlowTest1)}: Finishing at {DateTime.Now}");
    }

	[Test]
	public async Task N1SlowTest2()
	{
        TestContext.Progress.WriteLine($"{nameof(N1SlowTest2)}: Starting at {DateTime.Now}");
        await Task.Delay(TimeSpan.FromSeconds(10));
        TestContext.Progress.WriteLine($"{nameof(N1SlowTest2)}: Finishing at {DateTime.Now}");
	}
}

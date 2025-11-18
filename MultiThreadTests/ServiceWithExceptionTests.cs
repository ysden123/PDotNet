using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MultiThreadTests;

public class ServiceWithExceptionTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task TestOnceMethod1()
    {
        try
        {
            string? result = await ServiceWithException.Method1(true);
            Assert.That(result, Is.Null);
        }
        catch (Exception ex)
        {
            Assert.That(ex, Is.TypeOf<InvalidOperationException>());
            Assert.That(ex.Message, Is.EqualTo("An error occurred in Method1's task."));
        }
    }

    [Test]
    public async Task TestSeveralTimesMethod1AllFail()
    {
        try
        {
            var taskList = new List<Task<string>>()
            {
                ServiceWithException.Method1(true),
                ServiceWithException.Method1(true)
            };

            string[]? result = await Task.WhenAll(taskList);
            Assert.Fail("Exception must be thrown!");
        }
        catch (Exception ex)
        {
            Assert.That(ex, Is.TypeOf<InvalidOperationException>());
            Assert.That(ex.Message, Is.EqualTo("An error occurred in Method1's task."));
        }
    }

    [Test]
    public async Task TestSeveralTimesMethod1AllSucceed()
    {
        try
        {
            var taskList = new List<Task<string>>()
            {
                ServiceWithException.Method1(false),
                ServiceWithException.Method1(false)
            };

            string[]? result = await Task.WhenAll(taskList);
            Assert.That(result, Is.Not.Null);
        }
        catch (Exception ex)
        {
            Assert.Fail("No exception must be thrown!");
        }
    }

    [Test]
    public async Task TestSeveralTimesMethod1FirstFail()
    {
        try
        {
            var taskList = new List<Task<string>>()
            {
                ServiceWithException.Method1(true),
                ServiceWithException.Method1(false)
            };

            string[]? result = await Task.WhenAll(taskList);
            Assert.Fail("Exception must be thrown!");
        }
        catch (Exception ex)
        {
            Assert.That(ex, Is.TypeOf<InvalidOperationException>());
            Assert.That(ex.Message, Is.EqualTo("An error occurred in Method1's task."));
        }
    }

    [Test]
    public async Task TestSeveralTimesMethod1SecondFail()
    {
        try
        {
            var taskList = new List<Task<string>>()
            {
                ServiceWithException.Method1(false),
                ServiceWithException.Method1(true)
            };

            string[]? result = await Task.WhenAll(taskList);
            Assert.Fail("Exception must be thrown!");
        }
        catch (Exception ex)
        {
            Assert.That(ex, Is.TypeOf<InvalidOperationException>());
            Assert.That(ex.Message, Is.EqualTo("An error occurred in Method1's task."));
        }
    }
}

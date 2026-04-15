namespace ClassMSTests;

internal class ClassWithNestedClasses
{
    private int _count;

    private readonly CountManager _countManager;
    private readonly StringManager _stringManager;

    class CountManager(ClassWithNestedClasses parent)
    {
        public void Increment()
        {
            parent._count++;
        }

        public void Decrement()
        {
            parent._count--;
        }

        public int GetCount()
        {
            return parent._count;
        }
    }

    class StringManager(ClassWithNestedClasses parent)
    {
        public string GetString()
        {
            parent._count++;
            return $"Current count is: {parent._countManager.GetCount()}";
        }
    }

    public ClassWithNestedClasses()
    {
        _count = 0;
        _countManager = new CountManager(this);
        _stringManager = new StringManager(this);
    }

    public int PlayWithCount()
    {
        _countManager.Increment();
        _countManager.Increment();
        _countManager.Increment();
        return _countManager.GetCount();
    }

    public int PlayWithCount2()
    {
        _count = 0;
        return _countManager.GetCount();
    }

    public string PlayWithString()
    {
        _count = 0;
        return _stringManager.GetString();
    }
}
namespace WpfUIEx
{
    internal class LongProcess1
    {
        private readonly Action<int, int> _init;
        private readonly Action<int> _update;

        public LongProcess1(Action<int, int> init, Action<int> update)
        {
            _init = init;
            _update = update;
        }
        public void Start()
        {
            var thread = new Thread(new ThreadStart(Process));
            thread.Start();
        }

        private void Process()
        {
            var start = 0;
            var finish = 123;
            _init(start, finish);
            for (var i = start; i <= finish; ++i)
            {
                Thread.Sleep(50);
                _update(i);
            }
        }
    }
}

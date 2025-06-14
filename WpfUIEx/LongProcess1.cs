using Serilog;

namespace WpfUIEx
{
    internal class LongProcess1
    {
        private readonly ILogger _logger;
        private readonly Action<int, int> _init;
        private readonly Action<int> _update;

        public LongProcess1(Action<int, int> init, Action<int> update)
        {
            _init = init;
            _update = update;
            _logger = Log.ForContext<LongProcess1>();
        }
        public void Start()
        {
            _logger.Debug("==>Start");
            var thread = new Thread(new ThreadStart(Process));
            thread.Start();
            _logger.Debug("<==Start");
        }

        private void Process()
        {
            _logger.Debug("==>Process");
            var start = 0;
            var finish = 123;
            _init(start, finish);
            for (var i = start; i <= finish; ++i)
            {
                Thread.Sleep(50);
                _update(i);
            }
            _logger.Debug("<==Process");
        }
    }
}

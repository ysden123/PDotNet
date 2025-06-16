using Serilog;

namespace MTIOPerformance
{
    internal class Service
    {
        private static readonly ILogger _logger;
        private static readonly string _directory = @"c:\work\test";
        private static readonly int _numberOfFiles = 100;
        private static readonly int _numberOfLines = 100000;
        private static readonly int _maxParallelCopies = 10;

        static Service()
        {
            _logger = Log.ForContext<Service>();
        }

        public static void CreateFilesSync()
        {
            _logger.Information("==>CreateFilesSync");
            Clear();
            try
            {
                var start = DateTime.Now;
                for (int i = 0; i < _numberOfFiles; i++)
                {
                    var path = $@"{_directory}\file{i}.txt";
                    CreateFile(path);
                }
                _logger.Information("{duration}", BuildDuration(start));
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
            }

            Clear();

            _logger.Information("<==CreateFilesSync");
        }

        public static async Task CreateFilesAsync()
        {
            _logger.Information("==>CreateFilesAsync");
            try
            {
                Clear();
                var tasks = new List<Task>();
                var semaphore = new SemaphoreSlim(_maxParallelCopies); // Control the degree of parallelism

                var start = DateTime.Now;
                for (int i = 0; i < _numberOfFiles; i++)
                {
                    int theI = i;
                    await semaphore.WaitAsync(); // Wait if maxParallelCopies limit is reached
                    tasks.Add(Task.Run(() =>
                    {
                        try
                        {
                            var path = $@"{_directory}\file{theI}.txt";
                            CreateFile(path);
                        }
                        finally
                        {
                            semaphore.Release(); // Release the slot
                        }
                    }));
                }
                await Task.WhenAll(tasks); // Wait for all copy tasks to complete

                _logger.Information("{duration}", BuildDuration(start));

                Clear();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
            }
            _logger.Information("<==CreateFilesAsync");
        }

        private static void CreateFile(string path)
        {
            //_logger.Information($"CreateFile: File {path}");
            try
            {
                //var options = new FileStreamOptions().
                using var writer = new StreamWriter(path);
                for (int i = 0; i < _numberOfLines; i++)
                {
                    var s = $"Line number {i}";
                    writer.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
            }
        }

        private static string BuildDuration(DateTime start)
        {
            var diff = DateTime.Now - start;
            var hours = diff.Hours;
            var minutes = diff.Minutes;
            var seconds = diff.Seconds;
            var milliseconds = diff.Milliseconds;
            return $"Duration is {hours:D2}:{minutes:D2}:{seconds:D2}:{milliseconds:D3}";
        }

        private static void Clear()
        {
            try
            {
                Directory.Delete(_directory, true);
            }
            catch (Exception)
            {
            }
            try
            {
                Directory.CreateDirectory(_directory);
            }
            catch (Exception ex)
            {
                _logger?.Error(ex, ex.Message);
            }
        }
    }
}

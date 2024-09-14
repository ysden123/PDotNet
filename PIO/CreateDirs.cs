namespace PIO
{
    internal class CreateDirs
    {
        public static void CreateDirEx01()
        {
            Console.WriteLine("==>CreateDirEx01");
            try
            {
                var newFilePath = @"c:\work\t1\t2\test.txt";
                var parentDir = Directory.GetParent(newFilePath);
                if (!parentDir!.Exists)
                {
                    parentDir.Create();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

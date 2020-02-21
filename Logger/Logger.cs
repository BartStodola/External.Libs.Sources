namespace Logger
{
    public class Logger : ILogger
    {
        public void Info(string txt)
        {
            System.Console.WriteLine("[info]"+txt);
        }

        public void Warn(string txt)
        {
            System.Console.WriteLine("[warn]" + txt);
        }
    }
}

namespace Business.CCC
{
    public class DatabaseLogger : ILooger
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!");
        }
    }
}

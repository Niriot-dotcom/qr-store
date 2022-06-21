namespace _3P_PatyLopez
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Subject singletonSubject = Subject.GetInstance();
            Subject s2 = Subject.GetInstance();

            if (singletonSubject == s2)
            {
                Console.WriteLine(">> Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine(">> Singleton failed, variables contain different instances.");
            }

            // initialize frontend
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
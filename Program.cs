namespace _3P_PatyLopez
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
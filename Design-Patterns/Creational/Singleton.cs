using System;

namespace DesignPatterns.Creational
{
    public class Singleton
    {
        public static void Run()
        {
            Log.Info("Singleton Pattern");
            Me.Instance.Print();
            You.GetInstance().Print();
        }
    }

    public class Me
    {
        public static readonly Me Instance = new Me();

        private Me() { }

        public void Print() => Console.WriteLine("There's only one of me!");
    } 

    public class You
    {
        private static You _instance;

        private You() { }

        public static You GetInstance()
        {
            if (_instance == null)
                _instance = new You();
            return _instance;
        }

        public void Print() => Console.WriteLine("There's only one of you!");
    }
}
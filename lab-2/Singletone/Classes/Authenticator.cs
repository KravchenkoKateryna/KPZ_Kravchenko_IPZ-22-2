namespace Singletone.Classes
{
    public sealed class Authenticator
    {
        private static volatile Authenticator instance;
        private static object syncRoot = new();

        private readonly int authId;

        private Authenticator()
        {
            authId = new Random().Next();
        }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance ??= new Authenticator();
                    }
                }

                return instance;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Identificator: {authId}");
        }
    }
}
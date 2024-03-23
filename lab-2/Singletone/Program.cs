using Singletone.Classes;
using System.IO.Pipes;

namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authenticator[] authenticators =
            [
                Authenticator.Instance,
                Authenticator.Instance,
            ];
            
            foreach (var authenticator in authenticators)
                authenticator.PrintInfo();
        }
    }
}

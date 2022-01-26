using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            int three = 3;
            int five = 5;
            int one = 1;
            int fifteen = 15;
            var sistema = new Sistema();
            result = sistema.Meta(three);
            Console.WriteLine(result);
            result = sistema.Meta(five);
            Console.WriteLine(result);
            result = sistema.Meta(one);
            Console.WriteLine(result);
            result =  sistema.Meta(fifteen);
            Console.WriteLine(result);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        static string GetUserInputFor(string prompt)
        {
            Console.WriteLine("");
            prompt = Console.ReadLine();
            return prompt;
        }




    }
}

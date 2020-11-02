using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        Random random = new Random();
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        
        }
        public Sweepstakes(string nameOfSweepstakes)
        {
            name = nameOfSweepstakes;
            contestants = new Dictionary<int, Contestant>();
            
        }
        public void RegisterConstestant(Contestant contestant)
        {

            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            List<int> keyList = new List<int>(contestants.Keys);
            int randomConstestantKey = keyList[random.Next(keyList.Count)];
            return contestants[randomConstestantKey];

        }   
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"This is {contestant.FirstName} {contestant.LastName}, their\n" +
                $" email is {contestant.EmailAddress} with a Registration no. of {contestant.RegistrationNumber}.");

        }

    }
}

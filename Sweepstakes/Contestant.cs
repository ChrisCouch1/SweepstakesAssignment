﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
            EmailAddress = this.EmailAddress;
            RegistrationNumber = this.RegistrationNumber;
        }
    }
}


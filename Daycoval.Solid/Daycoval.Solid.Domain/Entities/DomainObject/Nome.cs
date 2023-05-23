using System;
using System.Collections.Generic;
using System.Text;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Nome
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public override string ToString()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}

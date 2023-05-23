﻿namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Email
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }

        public string EnderecoEmail { get; private set; }
    }
}
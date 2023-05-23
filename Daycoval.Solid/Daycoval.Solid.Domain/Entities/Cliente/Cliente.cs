﻿using Daycoval.Solid.Domain.Entities.DomainObject;

namespace Daycoval.Solid.Domain.Entities.Cliente
{
    public class Cliente : Entity
    {
        public Cliente(Documento documento, Nome nome, Email email, Telefone telefone)
        {
            Documento = documento;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public Documento Documento { get; set; }
        public Nome Nome { get; set; }
        public Email Email { get; set; }
        public Telefone Telefone { get; set; }
    }
}
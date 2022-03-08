using System;
using System.Collections.Generic;
using System.Text;

namespace DepartamentoPolicia.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}

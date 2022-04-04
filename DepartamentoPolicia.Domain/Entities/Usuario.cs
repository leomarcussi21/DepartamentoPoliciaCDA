using DepartamentoPolicia.Domain.Models;

namespace DepartamentoPolicia.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}

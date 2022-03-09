using System;

namespace DepartamentoPolicia.Domain.Entities
{
    public class CodigoCriminal
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Penalidade { get; set; }
        public int TempoPrisao { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuarioCriacao { get; set; }
        public int IdUsuarioAlteracao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

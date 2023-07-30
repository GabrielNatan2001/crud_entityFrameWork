using Crud_Domain.Entity;

namespace Crud_Api.DataTransferObject
{
    public class ContatoDto
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public int DDI { get; set; }
        public string Telefone { get; set; }
        public int PessoaId { get; set; }

        public EntidadeContato MapToEntity()
        {
            return new EntidadeContato()
            {
                Id = this.Id,
                DDD = this.DDD,
                DDI = this.DDI,
                Telefone = this.Telefone,
                EntidadePessoaId = this.PessoaId
            };
        }
    }
}

using Crud_Domain.Entity;

namespace Crud_Api.DataTransferObject
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }

        public EntidadePessoa MapToEntity()
        {
            return new EntidadePessoa()
            {
                Id = this.Id,
                Nome= this.Nome,
                SobreNome= this.SobreNome,
                DtNascimento= this.DtNascimento,
            };
        }
    }
}

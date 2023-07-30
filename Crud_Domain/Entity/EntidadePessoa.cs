namespace Crud_Domain.Entity
{
    public class EntidadePessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DtNascimento { get; set; }
        public List<EntidadeContato> Contatos { get; set; }
    }
}

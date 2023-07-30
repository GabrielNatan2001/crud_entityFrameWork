namespace Crud_Domain.Entity
{
    public class EntidadeContato
    {
        public int Id { get; set; }
        public int DDI { get; set; }
        public int DDD { get; set; }
        public string Telefone { get;set; }
        public int EntidadePessoaId { get; set; }
    }
}

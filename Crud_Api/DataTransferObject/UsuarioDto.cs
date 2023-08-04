using Crud_Domain.Entity;

namespace Crud_Api.DataTransferObject
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }

        public EntidadeUsuario MapToEntity()
        {
            return new EntidadeUsuario()
            {
                Id = this.Id,
                Usuario = this.Usuario,
                Senha = CreateHashMD5(),
                Perfil = this.Perfil
            };
        }

        public string CreateHashMD5()
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(this.Senha);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
    }
}

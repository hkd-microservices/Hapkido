using hkd.ms.IdentityServer.Code;
using System.ComponentModel.DataAnnotations;

namespace IdentityServerAspNetIdentity.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public Faixa Faixa  { get; set; }

        public NivelUsuario NivelUsuario { get; set; }

        public bool Ativo { get; set; }

        public bool ConfirmacaoUsuario { get; set; }

        public string Imagepath { get; set; }

    }  
}

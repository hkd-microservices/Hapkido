using System.ComponentModel.DataAnnotations;

namespace Api.Data.Models
{
    public class Midia
    {
        [Key]
        public int Id { get; set; }

        public int Name { get; set; }

        public MidiaType Tipo { get; set; }


    }

}

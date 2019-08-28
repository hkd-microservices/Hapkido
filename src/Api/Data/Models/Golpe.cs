using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data.Models
{
    public class Golpe
    {
        [Key]
        public int IdGolpe { get; set; }

        public string Nome { get; set; }
        
        public string Descricao { get; set; }

        //public List<Midia> Midias { get; set; }

        public Midia MidiauCurta { get; set; }

        public Midia MidiaLonga { get; set; }

    }

}

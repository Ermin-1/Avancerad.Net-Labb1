using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1.Klasser
{
    public class Kopplingstabell
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("LärarId")]
        public Lärare Lärare { get; set; }
        public int LärarId { get; set; }


        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int StudentId { get; set; }


        [ForeignKey("KlassId")]
        public Klass Klass { get; set; }
        public int KlassId { get; set; }


        [ForeignKey("ÄmneId")]
        public Ämne Ämne { get; set; }
        public int ÄmneId { get; set; }
    }
}

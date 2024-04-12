using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avancerad.Net_Labb1.Klasser
{
    public class Ämne
    {
        [Key]
        public int ÄmneId { get; set; }
        public string ÄmneNamn { get; set; }
        ICollection<Kopplingstabell> Kopplingstabeller { get; set; }
    }
}

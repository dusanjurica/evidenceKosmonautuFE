using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosmonauti.Data
{
    public class KosmonautDTO
    {
        public int Id { get; set; }

        [Required]
        public string Jmeno { get; set; }

        [Required]
        public string Prijmeni { get; set; }

        [Required]
        public DateTime DatumNar { get; set; }

        public IList<string> Superschopnosti { get; set; }

        public IList<int> SuperschopnostiIds { get; set; }
    }
}
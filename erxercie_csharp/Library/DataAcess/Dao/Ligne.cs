using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcess.Dao
{
    public class Ligne
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } // Verifier le type
        public DateTime Heure { get; set; } // 
        public float Temperature { get; set; }
        public int Hygrometrie { get; set; }

        public int ReleveId { get; set; }
        [ForeignKey("ReleveId")]
        public virtual Releve Releve { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAcess.Dao
{
    public class Releve
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime DateReleve { get; set; }
        public DateTime DateImport { get; set; }

        public int CapteurId { get; set; }
        [ForeignKey("CapteurId")]
        public virtual Capteur Capteur { get; set; }
    }
}

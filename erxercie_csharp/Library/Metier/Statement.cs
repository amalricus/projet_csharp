using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Metier
{
    public class Statement
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime StatementDate { get; set; }
        public DateTime ImportDate { get; set; }

        public List<Line> LineList { get; set; }



    }
}

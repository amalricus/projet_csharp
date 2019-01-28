using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Metier
{
    public class Line
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public float Temperature { get; set; }
        public int Hygrometry { get; set; }
    }
}

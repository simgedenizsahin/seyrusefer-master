using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seyrusefer
{
   public class Bilet
    {
        public Musteri musteri { get; set; }
        public int SeciliKoltuk { get; set; }
        public Bilet()
        {
            SeciliKoltuk = 0;
        }
    }
}

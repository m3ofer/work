using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class Produit
    {
        public int Code { get; set; }
        public string Designation { get; set; }
        public Produit()
        {
            Code = 0;
            Designation = "";
        }

    }
}

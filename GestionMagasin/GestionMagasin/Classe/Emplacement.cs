using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasin.Classe
{
  public  class Emplacement
    {
        public int id { get; set; }
  
        public string Designation { get; set; }
        public Service service { get; set; }
    }
}

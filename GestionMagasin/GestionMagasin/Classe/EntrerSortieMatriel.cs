using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasin.Classe
{
 public   class EntrerSortieMatriel
    {
        public int id { get; set;}
        public DateTime DateEntrer { get; set; }
        public DateTime DateSortie { get; set; }
        public string RaisonSortie { get; set; }
        public string Observation { get; set; }
        public Matriel matriel { get; set; }
        public Emplacement emplacement { get; set; }
    }
}

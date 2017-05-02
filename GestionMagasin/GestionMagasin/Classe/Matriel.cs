using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMagasin.Classe
{
  public  class Matriel
    {
        [Key]
        public string NumeroInvontaire { get; set; }
        public string Designation { get; set; }
        public string Model { get; set; }
        public string Numero_Serie { get; set; }
        public  DateTime DateMiseService { get; set; }
        public string Observation { get; set; }
        public float acquisition { get; set; }
        public string valeurAcquisition { get; set; }
        public bool IsValeurAcquisitionExist { get; set; }
        public string EtatPhysique { get; set; }
        public bool IsExistStok { get; set; }
        public int   Dimension { get; set; }
        public string Numero_INN { get; set; }
      public Categorie_Matriel categorie { get; set; }
      public override string ToString()
      {
          return categorie.Designation;
      }

    }
}

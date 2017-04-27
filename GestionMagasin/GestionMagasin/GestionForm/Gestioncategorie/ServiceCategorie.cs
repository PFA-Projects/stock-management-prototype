using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.Gestioncategorie
{
    class ServiceCategorie
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Categorie_Matriel s)
        {
            db.CMatriels.Add(s);
            return db.SaveChanges() > 0;
        }
        public Categorie_Matriel RechercheParId(int id)
        {
            Categorie_Matriel s = db.CMatriels
                .Where(i => i.id == id)
                .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.CMatriels.Find(id);
            db.CMatriels.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Categorie_Matriel  s)
        {
            var original = db.CMatriels.Find(s.id);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }
       /* public List<Categorie_Matriel> Recherche(int Id, string Nom, string Prenom, string Operation)
        {
            List<Categorie_Matriel> CMatriels  = db.CMatriels.Where(s =>
            Operation == "AND" ?(Id == s.id ).ToList<Categorie_Matriel>();
            return CMatriels;
        }
        */
        public List<Categorie_Matriel> ListStagiaires()
        {
            var query = from s in db.CMatriels select s;
            return query.ToList<Categorie_Matriel>();

        }

        public void valider()
        {
            db.SaveChanges();
        }







    }
}

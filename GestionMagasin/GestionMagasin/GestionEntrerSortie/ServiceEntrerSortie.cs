using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionEntrerSortie
{
    class ServiceEntrerSortie
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(EntrerSortieMatriel s)
        {
            db.EntreSortie.Add(s);
            return db.SaveChanges() > 0;
        }
        public EntrerSortieMatriel RechercheParId(int id)
        {
            EntrerSortieMatriel s = db.EntreSortie
                .Where(i => i.id == id)
                .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.EntreSortie.Find(id);
            db.EntreSortie.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(EntrerSortieMatriel s)
        {
            var original = db.EntreSortie.Find(s.id);

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
        public List<EntrerSortieMatriel> ListStagiaires()
        {
            var query = from s in db.EntreSortie select s;
            return query.ToList<EntrerSortieMatriel>();

        }

        public void valider()
        {
            db.SaveChanges();
        }


    }
}

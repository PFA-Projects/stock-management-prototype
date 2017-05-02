using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionMatriel
{
    class ServiceMatriel
    {

        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Matriel s)
        {
            db.Matriels.Add(s);
            return db.SaveChanges() > 0;
        }
        public Matriel RechercheParId(string id)
        {
            Matriel s = db.Matriels
                  .Where(i => i.NumeroInvontaire == id)
                  .SingleOrDefault();
            return s;
        }
        public bool Supprimer(string id)
        {
            var s = db.Matriels.Find(id);
            db.Matriels.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Matriel s)
        {
            var original = db.Matriels.Find(s.NumeroInvontaire);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        public List<Matriel> ListStagiaires()
        {
            var query = from s in db.Matriels select s;
            return query.ToList<Matriel>();

        }

        public void valider()
        {
            db.SaveChanges();
        }


    }
}

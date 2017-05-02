using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionLivraison
{
    class ServiceLivraison
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Livraison s)
        {
            db.Livraisons.Add(s);
            return db.SaveChanges() > 0;
        }
        public Livraison RechercheParId(int id)
        {
          Livraison  s = db.Livraisons
                .Where(i => i.id == id)
                .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.Livraisons.Find(id);
            db.Livraisons.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Livraison s)
        {
            var original = db.Livraisons.Find(s.id);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        public List<Livraison> ListStagiaires()
        {
            var query = from s in db.Livraisons select s;
            return query.ToList<Livraison>();

        }

        public void valider()
        {
            db.SaveChanges();
        }



    }
}

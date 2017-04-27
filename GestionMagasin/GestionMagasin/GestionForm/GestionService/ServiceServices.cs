using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;
 

namespace GestionMagasin.GestionService
{
    class ServiceServices
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Service s)
        {
            db.services.Add(s);
            return db.SaveChanges() > 0;
        }
        public Service RechercheParId(int id)
        {
            Service s= db.services
                  .Where(i => i.id == id)
                  .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.services.Find(id);
            db.services.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Service s)
        {
            var original = db.services.Find(s.id);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        public List<Service> List()
        {
            var query = from s in db.services select s;
            return query.ToList<Service>();

        }

        public void valider()
        {
            db.SaveChanges();
        }

    }
}

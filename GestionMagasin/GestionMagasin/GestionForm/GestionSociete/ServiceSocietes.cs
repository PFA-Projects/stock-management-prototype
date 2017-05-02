using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionSociete
{
    class ServiceSocietes
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Societe s)
        {
            db.Societes.Add(s);
            return db.SaveChanges() > 0;
        }
        public Societe RechercheParId(int id)
        {
            Societe s = db.Societes
                  .Where(i => i.id == id)
                  .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.Societes.Find(id);
            db.Societes.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Societe s)
        {
            var original = db.Societes.Find(s.id);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }


        public List<Societe> List()
        {
            var query = from s in db.Societes select s;
            return query.ToList<Societe>();

        }

        public void valider()
        {
            db.SaveChanges();
        }
    }
}

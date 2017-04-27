using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionMagasin.Classe;

namespace GestionMagasin.GestionEmplacement
{
    class ServiceEmplacement
    {
        Model.ModelMagazin db = new Model.ModelMagazin();
        public bool Ajouter(Emplacement s)
        {
            db.Emplacements.Add(s);
            return db.SaveChanges() > 0;
        }
        public Emplacement RechercheParId(int id)
        {
            Emplacement s = db.Emplacements
                .Where(i => i.id == id)
                .SingleOrDefault();
            return s;
        }
        public bool Supprimer(int id)
        {
            var s = db.Emplacements.Find(id);
            db.Emplacements.Remove(s);
            return db.SaveChanges() > 0;
        }

        public bool Update(Emplacement s)
        {
            var original = db.Emplacements.Find(s.id);

            if (original != null)
            {
                db.Entry(original).CurrentValues.SetValues(s);
                return db.SaveChanges() > 0;
            }
            return false;
        }
       
         
        public List<Emplacement> ListStagiaires()
        {
            var query = from s in db.Emplacements select s;
            return query.ToList<Emplacement>();

        }

        public void valider()
        {
            db.SaveChanges();
        }





    }
}

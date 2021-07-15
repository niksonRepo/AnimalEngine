using System.Linq;
using AnimalEngine.Entity;
using AnimalEngine.UI.Context;

namespace AnimalEngine.DAL
{
    public class AnimalEngineRepository
    {
        public void AddCat(CatDto cat)
        {
            using ( var context = new AnimalEngineDBContext () )
            {
                context.Add ( cat );
                var cats = context.Cats.Where ( x => x.Name == "Lucy" );
                context.SaveChanges ();
            }
        }

        public void UpdateCat ()
        {
            using ( var context = new AnimalEngineDBContext () )
            {
                var cat = context.Cats.Where ( x => x.Name == "DefaultName" ).FirstOrDefault ();
                cat.Name = "Lucy";

                context.Update(cat);
                context.SaveChanges ();
            }
        }

        public void RemoveCat ( )
        {
            using ( var context = new AnimalEngineDBContext () )
            {
                var cat = context.Cats.Where ( x => x.Name == "DefaultName" ).FirstOrDefault();
                if (cat != null)
                {
                    context.Remove(cat);
                    context.SaveChanges ();
                }
            }
        }
    }
}

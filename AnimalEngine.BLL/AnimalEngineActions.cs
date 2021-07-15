using AnimalEngine.Entity;
using AnimalEngine.DAL;
using AnimalEngine.UI.Context;
using System.Linq;

namespace AnimalEngine.BLL
{
    public class AnimalEngineActions
    {
        public string GetCatTalking(CatDto cat)
        {
            cat.WhatDoesCatSay = $"Cat { cat.Name} say mjau";
            using (var context = new AnimalEngineDBContext())
            {
                context.Add( cat );
                var cats = context.Cats.Where(x => x.Name == "Lucy");
                context.SaveChanges ();
            }

            return cat.WhatDoesCatSay;
        }


        public string GetDogTalking(DogDto dog)
        {
            return $"Dog {dog.Name} say gaf";
        }
    }
}

using AnimalEngine.Entity;
using AnimalEngine.DAL;
using AnimalEngine.UI.Context;
using System.Linq;

namespace AnimalEngine.BLL
{
    public class AnimalEngineActions
    {
        public string GetCatTalking ( CatDto cat )
        {
            var repo = new AnimalEngineRepository ();

            cat.WhatDoesCatSay = $"Cat { cat.Name} say mjau";
            
            repo.AddCat ( cat );
            repo.UpdateCat ();
            repo.RemoveCat ();
            return cat.WhatDoesCatSay;
        }


        public string GetDogTalking ( DogDto dog )
        {
            return $"Dog {dog.Name} say gaf";
        }
    }
}

using AnimalEngine.Entity;
using System;

namespace AnimalEngine.BLL
{
    public class AnimalEngineActions
    {
        public string getCatTalking(CatDto cat)
        {
            return $"Cat {cat.Name} say mjau";
        }


        public string getDogTalking(DogDto dog)
        {
            return $"Dog {dog.Name} say gaf";
        }
    }
}

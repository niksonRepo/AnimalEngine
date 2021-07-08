using AnimalEngine.Entity;
using AnimalEngine.UI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalEngine.UI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<CatViewModel, CatDto>();
            CreateMap<DogViewModel, DogDto>();
        }
    }
}

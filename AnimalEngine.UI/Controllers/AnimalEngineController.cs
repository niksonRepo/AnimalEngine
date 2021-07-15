using AnimalEngine.BLL;
using AnimalEngine.Entity;
using AnimalEngine.UI.Context;
using AnimalEngine.UI.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalEngine.UI.Controllers
{
    public class AnimalEngineController : Controller
    {
        private readonly IMapper _mapper;

        public AnimalEngineController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            CatViewModel catModel = new CatViewModel ()
            {
                Id = 1,
                Name = "Lucky",
                NameOfOwner = "Jack"
            };

            return View(catModel);
        }


        public IActionResult GetAnimalInfo(string animalName = "DefaultName")
        {
            CatViewModel catModel = new CatViewModel()
            {
                //Id = 2,
                Name = animalName,
                NameOfOwner = "John"
            };

            var catdto = _mapper.Map<CatDto>(catModel);

            //CatDto catdto = new CatDto()
            //{
            //    Id = catModel.Id,
            //    Name = catModel.Name,
            //    NameOfOwner = catModel.NameOfOwner
            //};


            //using ( var context = new AnimalEngineDBContext () )
            //{
            //    context.Add(catModel);
            //    context.SaveChanges();
            //}

            AnimalEngineActions animalActions = new AnimalEngineActions();

            catModel.WhatDoesCatSay = animalActions.GetCatTalking(catdto);

            return View(catModel);
        }
    }
}

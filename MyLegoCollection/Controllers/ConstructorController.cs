using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLegoCollection.Models;
using MyLegoCollection.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyLegoCollection.Controllers
{
    public class ConstructorController : Controller
    {
        private readonly IConstructorRepository constructorRepository;
        private readonly IThemeRepository themeRepository;

        public ConstructorController(IConstructorRepository constructorRepository, IThemeRepository themeRepository)
        {
            this.themeRepository = themeRepository;
            this.constructorRepository = constructorRepository;
        }

        public ViewResult List()
        {
            ConstructorsListViewModel constructorsListViewModel = new ConstructorsListViewModel();
            
            constructorsListViewModel.Constructors = constructorRepository.AllContructors;
            constructorsListViewModel.CurrentTheme = "My theme";

            return View(constructorsListViewModel);
        }
    }
}

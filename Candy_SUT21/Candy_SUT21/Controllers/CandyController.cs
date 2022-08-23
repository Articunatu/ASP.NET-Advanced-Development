using Candy_SUT21.Models;
using Candy_SUT21.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Candy_SUT21.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _candyRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CandyController(ICandyRepository candyRepository, ICategoryRepository categoryRepository)
        {
            _candyRepository = candyRepository;
            _categoryRepository = categoryRepository;  
        }

        public ViewResult List()
        {
            //ViewBag.CurrentCategory = "Bestseller";

            CandyListViewModel candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _candyRepository.GetAllCandies;
            candyListViewModel.CurrentCategory = "BestSeller";
            return View(candyListViewModel);
        }

        public IActionResult Details(int id)
        {
            Candy candy = _candyRepository.GetCandyByID(id);
            if (candy == null)
            {
                return NotFound();
            }

            return View(candy);
        }
    }
}

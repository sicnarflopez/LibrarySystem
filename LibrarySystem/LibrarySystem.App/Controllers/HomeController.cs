using LibrarySystem.App.Models;
using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RestSharp;
using static LibrarySystem.App.Models.StackOverflowData.Item;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger,
                              ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetCategories();
            
            List<SelectListItem> categoriesListItems = categories.ConvertAll(a =>
            {
                return new SelectListItem()
                {
                    Text = a.Description,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });

            return View(categoriesListItems);
        }

        public async Task<IActionResult> ExternalApi()
        {
            var url = "https://api.stackexchange.com/2.3/questions?pagesize=50&order=desc&sort=activity&site=stackoverflow";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            
            var data = JsonConvert.DeserializeObject<StackOverflowData>(response.Content);

            var viewModel = data.items.Select(x => new HomeViewModel
            {
                Id = x.question_id,
                Title = x.title,
                Link = x.link,
                Owner = x.owner.display_name
            }).ToList();

            return View(viewModel);
        }
        
        public async Task<IActionResult> Details(int id)
        {
            var url = "https://api.stackexchange.com/2.3/questions/"+ id +"?order=desc&sort=activity&site=stackoverflow";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);

            var data = JsonConvert.DeserializeObject<QuestionData>(response.Content);

            var viewModel = data.items.Select(x => new DetailsViewModel()
            {
                Title = x.title,
                Owner = x.owner.display_name,
                Link = x.link,
                IsAnswered = x.is_answered ? "Yes" : "No",
                Views = x.view_count.ToString(),
                Tags = String.Join(',',x.tags)
            }).ToList();

            return View(viewModel.FirstOrDefault());
        }
    }
}
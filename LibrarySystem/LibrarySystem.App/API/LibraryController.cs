using LibrarySystem.Logic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.App.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public LibraryController(IBookService bookService,
                                 ICategoryService categoryService,
                                 ISubCategoryService subCategoryService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }

        [HttpGet("get-subcategories/{id}")]
        public async Task<IActionResult> GetSubCategoriesByCategoryId(int id)
        {
            var subCategories = await _subCategoryService.GetAllByCategoryId(id);
            return Ok(subCategories);
        }
        
        [HttpGet("get-books-by-sub/{id}")]
        public async Task<IActionResult> GetBooksBySubCategoryId(int id)
        {
            var books = await _bookService.GetBooksBySubCategoryId(id);

            var bookDetails = books.Select(x => new
            {
                Id = x.Id,
                Title = x.Title,
                Author = x.Author.AuthorName
            }).ToList();

            return Ok(bookDetails);
        }

        //Get data using StoredProc
        [HttpGet("get-books")]
        public IActionResult GetBooks()
        {
            var books = _bookService.GetBooksFromSp();

            return Ok(books);
        }
    }
}

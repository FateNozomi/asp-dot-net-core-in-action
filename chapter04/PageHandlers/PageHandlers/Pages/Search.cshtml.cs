using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace PageHandlers.Pages
{
    public class SearchModel : PageModel
    {
        private readonly SearchService _searchService;

        public SearchModel(SearchService searchService)
        {
            _searchService = searchService;
        }

        [BindProperty]
        public BindingModel? Input { get; set; }
        public List<Product>? Results { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Results = _searchService.SearchProducts(Input!.SearchTerm!);
                return Page();
            }

            return RedirectToPage();
        }

        public class BindingModel
        {
            [Required]
            public string? SearchTerm { get; set; }
        }
    }
}

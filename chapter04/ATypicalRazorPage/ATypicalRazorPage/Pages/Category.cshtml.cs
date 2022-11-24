using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATypicalRazorPage.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly ToDoService _service;

        public CategoryModel(ToDoService service)
        {
            _service = service;
        }

        public List<ToDoListModel> Items { get; set; } = new List<ToDoListModel>();

        public ActionResult OnGet(string category)
        {
            Items = _service.GetItemsForCategory(category);
            return Page();
        }
    }
}

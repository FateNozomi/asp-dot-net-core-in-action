using ConvertingToMVC.Models;

namespace ConvertingToMVC.ViewModels
{
    public class CategoryViewModel
    {
        public List<ToDoList> Items { get; set; }

        public CategoryViewModel(List<ToDoList> items)
        {
            Items = items;
        }
    }
}

using ConvertingToMVC.Models;

namespace ConvertingToMVC.Services
{
    public class ToDoService
    {
        // These would normally be loaded from a database for example
        private static readonly List<ToDoList> _items = new List<ToDoList>
        {
            new ToDoList{Category= "Simple", Title="Bread"},
            new ToDoList{Category= "Simple", Title="Milk"},
            new ToDoList{Category= "Simple", Title="Get Gas"},
            new ToDoList{Category= "Long", Title="Write Book"},
            new ToDoList{Category= "Long", Title="Build Application"},
        };

        public List<ToDoList> GetItemsForCategory(string category)
        {
            // filter by the provided category
            return _items.Where(x => x.Category == category).ToList();
        }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;

namespace BindDDLWithDb.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SelectListItem> userListItem { get; set; }
    }
}

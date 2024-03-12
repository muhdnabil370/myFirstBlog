using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myFirstBlogRazor_Temp.Data;
using myFirstBlogRazor_Temp.Models;

namespace myFirstBlogRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if (id != 0 || id != null)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

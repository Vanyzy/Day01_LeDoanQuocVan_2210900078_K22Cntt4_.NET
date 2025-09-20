using Day03Demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day03Demo1.ViewComponents
{
    public class CatagoryViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> categories = new List<Category>()
            {
                new Category {Id=1,Name="Điện tử" },
                new Category {Id=2,Name="Điện Lạnh"},

                new Category {Id=3,Name="Đồ gia dụng"},
                new Category {Id=4,Name="Tiện ích"},
            };
            return View(categories);
        }

        private IViewComponentResult View(List<Category> categories)
        {
            throw new NotImplementedException();
        }
    }
}

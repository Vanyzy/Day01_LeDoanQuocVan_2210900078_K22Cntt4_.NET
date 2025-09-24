using Day05Demo1.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Day05Demo1.Controllers
{
    public class MemberController : Controller
    {
   
            // B1: Khai báo danh sách member static
            public static readonly List<Member> members = new List<Member>()
        {
            new Member{ MemberId = Guid.NewGuid().ToString(), Username="member1", Fullname="Thành viên 1", Password="123456", Email="tv1@gmail.com"},
            new Member{ MemberId = Guid.NewGuid().ToString(), Username="member2", Fullname="Thành viên 2", Password="123456", Email="tv2@gmail.com"},
            new Member{ MemberId = Guid.NewGuid().ToString(), Username="member3", Fullname="Thành viên 3", Password="123456", Email="tv3@gmail.com"},
            new Member{ MemberId = Guid.NewGuid().ToString(), Username="member4", Fullname="Thành viên 4", Password="123456", Email="tv4@gmail.com"},
            new Member{ MemberId = Guid.NewGuid().ToString(), Username="member5", Fullname="Thành viên 5", Password="123456", Email="tv5@gmail.com"},
        };

            // GET: /Member/GetMembers
            public IActionResult GetMembers()
            {
                ViewBag.members = members;
                return View();
            }

        // GET: Member/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Member/Create
        [HttpPost]
        public IActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                // Tạm thời chỉ hiển thị dữ liệu ra View
                // Bạn có thể thêm lưu vào DB ở đây nếu có database
                return RedirectToAction("Index", member);
            }
            return View(member);
        }

    }
}





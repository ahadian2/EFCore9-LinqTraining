using LinqTraining.Models;
using Microsoft.AspNetCore.Mvc;
namespace LinqTraining.Controllers
{
    public class HomeController : Controller
    {

        private List<Student> List = new List<Student>() {
            new Student{Id=1,Name="Mohammadreza",Family="Ahadian", Gender=true,Age=35,City="Tehran" },
            new Student{Id=2,Name="Atena",Family="Nazari", Gender=false,Age=35,City="Shiraz" },
            new Student{Id=3,Name="Masoud",Family="Jafari", Gender=true,Age=35,City="Tehran" },
            new Student{Id=4,Name="Shima",Family="Rezaei", Gender=false,Age=15,City="Shiraz" },
            new Student{Id=5,Name="Ahmad",Family="Hassani", Gender=true,Age=45,City="Esfehan" },
            new Student{Id=6,Name="Pantea",Family="Razavi", Gender=false,Age=43,City="Mazandaran" },
            new Student{Id=7,Name="Ali",Family="Mohammadi", Gender=true,Age=54,City="Tehran" },
            new Student{Id=8,Name="Sajedeh",Family="Taheri", Gender=false,Age=76,City="Tehran" },
            new Student{Id=9,Name="Akbar",Family="Samadi", Gender=true,Age=69,City="Ahvaz" },
            new Student{Id=10,Name="Hoda",Family="Ahmadi", Gender=false,Age=23,City="Ghazvin" },
            new Student{Id=11,Name="Morad",Family="Ebrahimi", Gender=true,Age=35,City="Mashhad" },
            new Student{Id=12,Name="Mahmod",Family="Asghari", Gender=true,Age=76,City="Mashhad" },
        };



        public IActionResult Index()
        {

            //var res = List.OrderBy(x=>x.Age).ToList();
            //var res=List.OrderByDescending(x => x.Age).ToList();
            //var res=List.OrderByDescending(x => x.Age).ThenByDescending(p=>p.Id).ToList();
            //var res = List.OrderBy(x=>x.Age).Reverse().ToList();

            //var res = List.Where(x => x.City == "Tehran").ToList();
            //var res = List.Where(x => x.City == "Tehran" && x.Gender==true && x.Age<36).ToList();
            var res = List.Where(x => x.City == "Shiraz" || x.City == "Esfehan").ToList();

            return View(res);
        }

        public IActionResult Select()
        {
            //var res = List.Select(x => x.Name).ToList();
            var res = List.Select(x => new {x.Name,x.Family}).ToList();
            ViewBag.MyList = res;
            return View();
        }

        public IActionResult avg() {

            //var res = List.Average(x => x.Age);
            //var res = List.Count();
            //var res = List.Where(x=>x.City=="Shiraz").Count();
            //var res = List.Max(x=>x.Age);
            //var res = List.Min(x=>x.Age);
            //var res = List.Sum(x=>x.Id);
            //var res = List.All(x => x.Age > 45);
            //var res = List.Any(x => x.Age == 14);
            var student = List.FirstOrDefault(x => x.Id == 100);
            var res=List.Contains(student);

            return Content(res.ToString());
        
        }

        public IActionResult Student()
        {

            try
            {
                var res = List.SingleOrDefault(x => x.Id == 1);
                return View(res);
            }
            catch (Exception)
            {
                return Content("null");
                throw;
            }



        }

    }
}

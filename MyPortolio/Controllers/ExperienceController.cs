using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly MyPortfolioContext _portfolioContext;
        public ExperienceController(MyPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }
        public IActionResult ExperinceList()
        {
            var values = _portfolioContext.Experinces.ToList();
            return View(values);
        }
    }
}

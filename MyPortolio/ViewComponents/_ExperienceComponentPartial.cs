using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _portfolioContext;
        public _ExperienceComponentPartial(MyPortfolioContext portfolioContext)
        {
           _portfolioContext = portfolioContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Experinces.ToList();
            return View(values);
        }
    }
}

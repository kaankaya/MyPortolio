using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _portfolioContext;
        public _FeatureComponentPartial(MyPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }
        public IViewComponentResult Invoke()
        {
            //Context im de yeralan features deki verileri tolist metodu ile çağırdım ve view ' e return ettim
            var values = _portfolioContext.Features.ToList();
            return View(values);
        }
    }
}

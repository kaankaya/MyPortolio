using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _portfolioContext;
        public _AboutComponentPartial(MyPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext; 
        }
        public IViewComponentResult Invoke()
        {
            //sayfa üzerinden tasarımdan dolayı verileri viewbag ile taşıyacağız
            //burada context deki about içerisinde title verisini seçtik ve FirstOrDefault olarak tek veri olarak aldık
            ViewBag.aboutTitle = _portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.subDescription = _portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = _portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}

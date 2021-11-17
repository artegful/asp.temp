using System;
using Microsoft.AspNetCore.Mvc;

namespace WEB_953503_Klimovich.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

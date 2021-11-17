using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEB_953503_Klimovich.Models;

namespace WEB_953503_Klimovich.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems;

        public MenuViewComponent()
        {
            menuItems = new List<MenuItem>()
            {
                new MenuItem() {Controller = "Home", Action = "Index", Text = "Lab3"},
                new MenuItem() {Controller = "Product", Action = "Index", Text = "Каталог"},
                new MenuItem() {IsPage = true, Area = "Admin", Page = "/Index", Text = "Администрирование"}
            };
        }

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var area = ViewContext.RouteData.Values["area"];

            foreach (var item in menuItems)
            {
                bool isMatchingController = controller?.Equals(item.Controller) ?? false;
                bool isMatchingArea = area?.Equals(item.Area) ?? false;

                item.IsActive = isMatchingController || isMatchingArea;
            }
            return View(menuItems);
        }
    }
}

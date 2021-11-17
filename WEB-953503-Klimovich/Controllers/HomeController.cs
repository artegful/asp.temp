using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_953503_Klimovich.Controllers
{
    public class HomeController : Controller
    {
        public class ListItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
        }

        private const int ITEMS_AMOUNT = 5;
        private List<ListItem> collection;

        [ViewData]
        public string Text { get; set; }


        public HomeController()
        {
            collection = new List<ListItem>(ITEMS_AMOUNT);

            for (int i = 1; i <= ITEMS_AMOUNT; i++)
            {
                collection.Add(new ListItem
                {
                    Text = $"Item {i}",
                    Value = i
                });
            }
        }

        public IActionResult Index()
        {
            Text = "Лаба 2";
            ViewData["Collection"] = new SelectList(collection, nameof(ListItem.Value), nameof(ListItem.Text));

            return View();
        }
    }
}

using Restoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class MenuController : Controller
    {
        private OperationDataContext context = null;

        public MenuController()
        {
            context = new OperationDataContext();
        }
        public ActionResult Index()
        {
            List<MenuModel> menuList = new List<MenuModel>();
            List<MenuModel> mejaList = new List<MenuModel>();
            List<MenuModel> cList = new List<MenuModel>();
            var query = from menu in context.tMenus select menu;
            var query2 = from meja in context.tMejas select meja;

            var menus = query.ToList();
            var mejas = query2.ToList();

            foreach (var a in menus)
            {
                menuList.Add(new MenuModel()
                {
                    IdMenu = a.IdMenu,
                    Nama = a.Nama,
                    Harga = (int)a.Harga,
                    Stok = (int)a.Stok
                });
            }
            foreach (var a in mejas)
            {
                mejaList.Add(new MenuModel()
                {
                    IdMeja = a.IdMeja,
                    Status = (int)a.Status
                });
            }
            
            cList = menuList.Concat(mejaList).ToList();
            return View(cList);
        }

        //private MenuModel PreparePublisher(MenuModel model)
        //{
        //    model.tMejas = context.tMejas.AsQueryable<tMeja>().Select(x =>
        //    new SelectListItem()
        //    {
        //        Text = x.NoMeja.ToString(),
        //        Value = x.IdMeja
        //    });
        //    return model;
        //}

        //public ActionResult Edit(string id)
        //{
        //    MenuModel model = context.tMejas.Where(some => some.IdMeja == id).Select(
        //        some => new MenuModel()
        //        {
        //            IdMeja = some.IdMeja,
        //            Status = (int)some.Status

        //        }).SingleOrDefault();

        //    PreparePublisher(model);
        //    return View();
        //}

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using Restoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class QorderController : Controller
    {
        private OperationDataContext context = null;
        public QorderController()
        {
            context = new OperationDataContext();
        }

        // GET: Qorder
        public ActionResult Index()
        {
            List<QorderModel> mejaList = new List<QorderModel>();
            var query = from meja in context.tMejas
                        where meja.Status == 0
                        select new QorderModel
                        {
                            IdMeja = meja.IdMeja,
                            Status = (int)meja.Status 
                        };

            mejaList = query.ToList();
            return View(mejaList); ;
        }

        //[HttpPost]
        //public ActionResult Index(QorderModel model,string id)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here
        //        tOrder order = new tOrder()
        //        {
        //            MejaId = id,
        //        };

        //        context.tOrders.InsertOnSubmit(order);
        //        context.SubmitChanges();
        //        return RedirectToAction("PesanMenu");
        //    }
        //    catch
        //    {
        //        return View(model);
        //    }
        //}

        public ActionResult PesanMenu(string id)
        {
            List<QorderModel> menuList = new List<QorderModel>();
            var query = from order in context.tOrders
                        join menu in context.tMenus
                        on order.MenuId equals menu.IdMenu
                        join meja in context.tMejas
                        on order.MejaId equals meja.IdMeja
                        select new QorderModel
                        {
                            IdMeja = id,
                            IdMenu = menu.IdMenu,
                            Nama = menu.Nama,
                            Harga = (int)menu.Harga,
                            Images = menu.Images,
                            Jumlah = (int)order.JumlahMenu
                        };
            menuList = query.ToList();
            return View(menuList); 
        }

        public ActionResult Add(QorderModel model,string idMenu, string idMeja)
        {
            tOrder order = new tOrder()
            {
                MejaId = idMeja,
                MenuId = idMenu,
                JumlahMenu = model.Jumlah
            };

            context.tOrders.InsertOnSubmit(order);
                context.SubmitChanges();
                return RedirectToAction("PesanMenu");
        }
    }
}
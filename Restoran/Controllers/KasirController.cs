using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restoran.Models;

namespace Restoran.Controllers
{
    public class KasirController : Controller
    {
        private OperationDataContext context = null;
        public KasirController()
        {
            context = new OperationDataContext();
        }

        
        public ActionResult Index()
        {
            List<KasirModel> mejaList = new List<KasirModel>();
            List<String> meja2List = new List<String>();
            List<KasirModel> meja3List = new List<KasirModel>();
            var query = from order in context.tOrders
                        join menu in context.tMenus
                        on order.MenuId equals menu.IdMenu
                        join meja in context.tMejas
                        on order.MejaId equals meja.IdMeja
                        select new KasirModel
                        {
                            IdMeja = meja.IdMeja,
                            Nama = menu.Nama,
                            Harga = (int)menu.Harga,
                            Jumlah = (int)order.JumlahMenu
                        };

            //var bebas = mejaList.Distinct();
           mejaList = query.Distinct().ToList();
            foreach(var a in mejaList)
            {
                if (!meja2List.Contains(a.IdMeja))
                {
                    meja3List.Add(a);
                    meja2List.Add(a.IdMeja);
                }
            }
            //if (query != null) query = query.Distinct(x => x.IdMeja).ToList();
            //return View(bebas);
            return View(meja3List);
        }

        public ActionResult Detail(string id)
        {
            //KasirModel model = context.tMejas.Where(some => some.IdMeja == id).Join().Select(
            //   some => new OrderModel()
            //   {
            //       IdOrder = some.IdOrder,
            //       MejaId = some.MejaId,
            //       MenuId = some.MenuId,
            //       JumlahMenu = (int)some.JumlahMenu
            //   }).SingleOrDefault();
            List<KasirModel> menuList = new List<KasirModel>();
            var query = from order in context.tOrders
                        join menu in context.tMenus
                        on order.MenuId equals menu.IdMenu
                        join meja in context.tMejas
                        on order.MejaId equals meja.IdMeja
                        where meja.IdMeja == id
                        
                        select new KasirModel
                        {
                            IdMeja = meja.IdMeja,
                            Nama = menu.Nama,
                            Harga = (int)menu.Harga,
                            Jumlah = (int)order.JumlahMenu,
                            Total = (int)menu.Harga * (int)order.JumlahMenu
                        };
            menuList = query.ToList();
            return View(menuList);
        }
    }
}
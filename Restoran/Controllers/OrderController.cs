using Restoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Restoran.Models.OrderModel;

namespace Restoran.Controllers
{
    public class OrderController : Controller
    {
        private OperationDataContext context = null;
        public OrderController()
        {
            context = new OperationDataContext();
        }
        // GET: Order
        public ActionResult Index()
        {
            List<OrderModel> orderList = new List<OrderModel>();
            var query = from order in context.tOrders
                        join menu in context.tMenus
                        on order.MenuId equals menu.IdMenu
                        join meja in context.tMejas
                        on order.MejaId equals meja.IdMeja
                        select new OrderModel{
                            IdOrder = order.IdOrder,
                            MejaId = order.MejaId,
                            MenuId = order.MenuId,
                            Images = menu.Images,
                            JumlahMenu = (int)order.JumlahMenu,
                            Nama = menu.Nama
                };
            orderList = query.ToList();
            return View(orderList);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        private OrderModel PreparePublisher(OrderModel model)
        {
            model.tMejas = context.tMejas.AsQueryable<tMeja>().Select(x =>
            new SelectListItem()
            {
                Text = x.IdMeja,
                Value = x.IdMeja.ToString()
            });
            model.tMenus = context.tMenus.AsQueryable<tMenu>().Select(x =>
            new SelectListItem()
            {
                Text = x.Nama,
                Value = x.IdMenu.ToString()
            });
            return model;
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            OrderModel model = new OrderModel();
            PreparePublisher(model);

            //model.DaftarMenu = context.tMenus.AsQueryable<tMenu>().Select(x =>
            //new CheckBoxes
            //{
            //    Text = x.Nama,
            //    Value = x.IdMenu
            //});

            model.DaftarMenu = new List<CheckBoxes>
                {
                    new CheckBoxes { Text = "Nasi", Value="MK001"},
                    new CheckBoxes { Text = "Kentang", Value="MK002" },
                    new CheckBoxes { Text = "Kangkung", Value="MK003" },
                    new CheckBoxes { Text = "Es Teh Manis", Value="MN004" }
                };
            return View(model);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(OrderModel model)
        {
            try
            {
                // TODO: Add insert logic here
                tOrder order = new tOrder()
                {
                    MejaId = model.MejaId,
                    MenuId = model.MenuId,
                    JumlahMenu = model.JumlahMenu
                };
                
                context.tOrders.InsertOnSubmit(order);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            OrderModel model = context.tOrders.Where(some => some.IdOrder == id).Select(
               some => new OrderModel()
               {
                   IdOrder = some.IdOrder,
                   MejaId = some.MejaId,
                   MenuId = some.MenuId,
                   JumlahMenu = (int)some.JumlahMenu
               }).SingleOrDefault();

            PreparePublisher(model);
            return View(model);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(OrderModel model)
        {
            try
            {
                // TODO: Add update logic here
                tOrder order = context.tOrders.Where(some => some.IdOrder == model.IdOrder).SingleOrDefault();

                order.MejaId = model.MejaId;
                order.MenuId = model.MenuId;
                order.JumlahMenu = model.JumlahMenu;
                
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                OrderModel modela = new OrderModel();

                PreparePublisher(model);
                return View(model);
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            OrderModel model = context.tOrders.Where(some => some.IdOrder == id).Select(
               some => new OrderModel()
               {
                   IdOrder = some.IdOrder,
                   MejaId = some.MejaId,
                   MenuId = some.MenuId
               }).SingleOrDefault();

            PreparePublisher(model);
            return View(model);
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(OrderModel model)
        {
            try
            {
                // TODO: Add delete logic here

                tOrder order = context.tOrders.Where(some => some.IdOrder == model.IdOrder).SingleOrDefault();

                context.tOrders.DeleteOnSubmit(order);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

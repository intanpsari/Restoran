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
            var query = from menu in context.tMenus
                        select new MenuModel
                        {
                            IdMenu = menu.IdMenu,
                            Nama = menu.Nama,
                            Harga = (int)menu.Harga,
                            Stok = (int)menu.Stok,
                            Images = menu.Images
                        };
            menuList = query.ToList();
            return View(menuList);
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            MenuModel model = new MenuModel();
            
            return View(model);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(MenuModel model, HttpPostedFileBase file)
        {
            string gambar = "";
            if (file != null)
            {
                
                string ImageName = System.IO.Path.GetFileName(file.FileName);
                string physicalPath = Server.MapPath("~/images/" + ImageName);
                file.SaveAs(physicalPath);  
                gambar = ImageName;
            }
            try
            {
                // TODO: Add insert logic here
                tMenu menu = new tMenu()
                {
                    IdMenu = model.IdMenu,
                    Nama = model.Nama,
                    Harga = (int)model.Harga,
                    Stok = (int)model.Stok,
                    Images = gambar
                };

                context.tMenus.InsertOnSubmit(menu);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        public ActionResult Edit(string id)
        {
            MenuModel model = context.tMenus.Where(some => some.IdMenu == id).Select(
               some => new MenuModel()
               {
                   IdMenu = some.IdMenu,
                   Nama = some.Nama,
                   Harga = (int)some.Harga,
                   Stok = (int)some.Stok,
                   Images = some.Images
               }).SingleOrDefault();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(MenuModel model)
        {
            try
            {
                // TODO: Add update logic here
                tMenu menu = context.tMenus.Where(some => some.IdMenu == model.IdMenu).SingleOrDefault();

                menu.IdMenu = model.IdMenu;
                menu.Nama = model.Nama;
                menu.Harga = model.Harga;
                menu.Stok = model.Stok;
                menu.Images = model.Images;

                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                OrderModel modela = new OrderModel();
               
                return View(modela);
            }
        }

        public ActionResult Delete(string id)
        {
            MenuModel model = context.tMenus.Where(some => some.IdMenu == id).Select(
                some => new MenuModel()
                {
                    IdMenu = some.IdMenu,
                    Nama = some.Nama,
                    Harga = (int)some.Harga,
                    Stok = (int)some.Stok,
                    Images = some.Images
                }).SingleOrDefault();

            return View(model);
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(MenuModel model)
        {
            try
            {
                // TODO: Add delete logic here
                
                tMenu menu = context.tMenus.Where(some => some.IdMenu == model.IdMenu).SingleOrDefault();
                context.tMenus.DeleteOnSubmit(menu);
                context.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




        public ActionResult Data()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult IndexP()
        {
            List<MenuModel> pegawaiList = new List<MenuModel>();
            var query = from pegawai in context.tusers
                        select new MenuModel
                        {
                            username = pegawai.username,
                            password = pegawai.password
                        };
            pegawaiList = query.ToList();
            return View(pegawaiList);
        }

        public ActionResult EditP(string id)
        {
            MenuModel model = context.tusers.Where(some => some.username == id).Select(
               some => new MenuModel()
               {
                   username = some.username,
                   password = some.password
               }).SingleOrDefault();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditP(MenuModel model)
        {
            try
            {
                // TODO: Add update logic here
                tuser user = context.tusers.Where(some => some.username == model.username).SingleOrDefault();

                user.username = model.username;
                user.password = model.password;

                context.SubmitChanges();
                return RedirectToAction("IndexP");
            }
            catch
            {
                OrderModel modela = new OrderModel();

                return View(modela);
            }
        }

        public ActionResult CreateP()
        {
            MenuModel model = new MenuModel();

            return View(model);
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult CreateP(MenuModel model)
        {
            try
            {
                // TODO: Add insert logic here
                tuser user = new tuser()
                {
                    username = model.username,
                    password = model.password
                };

                context.tusers.InsertOnSubmit(user);
                context.SubmitChanges();
                return RedirectToAction("IndexP");
            }
            catch
            {
                return View(model);
            }
        }
    }
}
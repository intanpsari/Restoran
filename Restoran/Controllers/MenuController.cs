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
    }
}
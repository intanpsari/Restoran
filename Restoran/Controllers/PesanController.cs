using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restoran.Models;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class PesanController : Controller
    {
        private OperationDataContext context = null;

        public PesanController()
        {
            context = new OperationDataContext();
        }

        public ActionResult Index()
        {
            PesanModel model = new PesanModel();
            PreparePublisher(model);

            List<PesanModel> menuList = new List<PesanModel>();
            var query = from menu in context.tMenus
                        select new PesanModel
                        {
                            IdMenu = menu.IdMenu,
                            Nama = menu.Nama,
                            Images = menu.Images
                        };
            menuList = query.ToList();
            return View(menuList);
        }

        private PesanModel PreparePublisher(PesanModel model)
        {
            model.tMejas = context.tMejas.AsQueryable<tMeja>().Select(x =>
            new SelectListItem()
            {
                Text = x.IdMeja,
                Value = x.IdMeja.ToString()
            });
            return model;
        }

        public ActionResult Create()
        {
            PesanModel model = new PesanModel();
            PreparePublisher(model);
            return View(model);
        }

       
    }
}
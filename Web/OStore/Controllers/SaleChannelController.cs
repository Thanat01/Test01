using OStore.Models;
using OStore.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OStore.Controllers
{
    public class SaleChannelController : Controller
    {
        // GET: SaleChannel
        public ActionResult Index()
        {
            return View(SessionProvider.Instance.SaleChannels);
        }

        [HttpPost]
        public ActionResult ImportOrder()
        {
            bool isSavedSuccessfully = true;
            try
            {
                foreach (string fileName in Request.Files)
                {
                    //HttpPostedFileBase file = Request.Files[fileName];
                    //if (file != null && file.ContentLength > 0)
                    //{
                    //    ImageProvider.Instance.SaveCategory(file, Session["CategoryId"].ToString(), "1");
                    //}
                }
            }
            catch
            {
                isSavedSuccessfully = false;
            }

            if (isSavedSuccessfully)
                return Json(new { Message = "Primary" });
            else
                return Json(new { Message = "Error in saving file" });
        }
    }
}
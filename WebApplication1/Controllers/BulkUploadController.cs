using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;
using WebApplication1.ViewModels;
using WebApplication1.Models;
using System.IO;

namespace WebApplication1.Controllers
{
    public class BulkUploadController : Controller
    {
        // GET: BulkUpload
        [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }
        public ActionResult Upload(FileUploadViewModel model)
        {
            List<Employee> employees = GetEmployees(model);
            return RedirectToAction("Employee", "Index");
        }
        public List<Employee> GetEmployees(FileUploadViewModel model)
        {
            List<Employee> employees = new List<Employee>();
            StreamReader csvreader = new StreamReader(model.fileUpload.InputStream);
            csvreader.ReadLine();
            while(!csvreader.EndOfStream)
            {
                var c
            }
            return null;
        }
    }
}
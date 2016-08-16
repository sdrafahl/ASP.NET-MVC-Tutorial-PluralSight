using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EMPTYPAGE.Controllers.Web{

    public class AppController: Controller
    {
        public IActionResult Index(){
            
            return View("Views/App/index.cshtml");
        }
        public ActionResult Contact(){
            return View("Views/App/contact.cshtml");
        }
        public IActionResult About(){
            
            return View("Views/App/about.cshtml");
        }
        
    }
}
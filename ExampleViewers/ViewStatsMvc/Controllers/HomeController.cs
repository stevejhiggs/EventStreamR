﻿using ExampleViewers.ViewStatsMvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleViewers.ViewStatsMvc
{
    public class HomeController : Controller
    {
        //
        // GET: /Index/

        public ActionResult Index()
        {
            var model = new EventStreamViewModel();
            model.EventProxyHubUrl = ConfigurationManager.AppSettings["SignalREventReceiverHubUrl"];
            return View(model);
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRM.Web.Models;

namespace CRM.Web.Controllers;

public class CustomersController : Controller
{
    public ActionResult Index()
    {
        var list = new List<string>();
        list.Add("Mr. 1");
        list.Add("Mr. 2");
        list.Add("Mr. 3");
        list.Add("Mr. 4");
        list.Add("Mr. 5");

        ViewData["Customers"] = list;
        return View();
    }
}

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Shop.BLL;
using Shop.Models;

namespace Shop.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBll customerBll=new CustomerBll();

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            try
            {

                bool isAdded = customerBll.Add(customer);
                if (isAdded)
                {
                    ViewBag.SMsg = "Saved Success.";
                }
                else
                {
                    ViewBag.FMsg = "Save Failed.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            try
            {
                bool isUpdate = customerBll.Update(customer);
                if (isUpdate)
                {
                    ViewBag.SMsg = "Update Success.";
                }
                else
                {
                    ViewBag.FMsg = "Update Failed.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                bool isDelete = customerBll.Delete(customer);
                if (isDelete)
                {
                    ViewBag.SMsg = "Delete Success.";
                }
                else
                {
                    ViewBag.FMsg = "Delete Failed.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();


        }
        
        private int index = 1; 

        [HttpGet]
        public ActionResult Show()
        {
            List<Customer> customers= customerBll.Show(index);
            return View(customers);
        }

    }
}
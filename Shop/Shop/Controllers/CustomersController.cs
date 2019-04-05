using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Shop.BLL;
using Shop.Models;


namespace Shop.Controllers
{
    public class CustomersController : Controller
    {
        CustomerBll _customerBll=new CustomerBll();


        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            try
            {
                var aCustomer = _customerBll.GetCustomerById(customer.CustomerId);
                if (aCustomer ==null)
                {
                    var isAdded = _customerBll.Add(customer);
                    if (isAdded)
                    {
                        ViewBag.SMsg = "Saved Success.";
                    }
                    else
                    {
                        ViewBag.FMsg = "Save Failed.";
                    }
                }
                else
                {
                    ViewBag.FMsg = "Please check customer Id.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();
        }

        public ActionResult Update(int id)
        {
            var getCustomer = _customerBll.GetCustomerById(id);
            return View(getCustomer);
        }

        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            try
            {
                var aCustomer = _customerBll.GetCustomerById(customer.CustomerId);
                if (aCustomer != null)
                {
                    aCustomer.CustomerId = customer.CustomerId;
                    aCustomer.Name = customer.Name;
                    aCustomer.Code = customer.Code;
                    aCustomer.Address = customer.Address;
                    aCustomer.Email = customer.Email;
                    aCustomer.Contact = customer.Contact;
                    aCustomer.Age = customer.Age;
                    aCustomer.LoyalityPoint = customer.LoyalityPoint;
                    
                    var isUpdate = _customerBll.Update(aCustomer);
                    if (isUpdate)
                    {
                        ViewBag.SMsg = "Update Success.";
                    }
                    else
                    {
                        ViewBag.FMsg = "Update Failed.";
                    }
                }
                else
                {
                    ViewBag.FMsg = "Customer not found.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            try
            {
                var aCustomer = _customerBll.GetCustomerById(customer.CustomerId);
                if (aCustomer != null)
                {
                    var isDelete = _customerBll.Delete(aCustomer);
                    if (isDelete)
                    {
                        ViewBag.SMsg = "Delete Success.";
                    }
                    else
                    {
                        ViewBag.FMsg = "Delete Failed.";
                    }
                }
                else
                {
                    ViewBag.FMsg = "Customer not found.";
                }
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();

        }

        public ActionResult search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search()
        {
            var dataList = _customerBll.Search();
            return View(dataList);
        }

    }
}
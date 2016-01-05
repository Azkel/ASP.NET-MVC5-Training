using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Komsky.Data.Entities;
using Komsky.Web.Models;
using Komsky.Services.Handlers;
using Komsky.Domain.Models;
using Komsky.Web.Models.Factories;

namespace Komsky.Web.Controllers
{
    public class CustomerController : Controller
    {

        private readonly IBaseHandler<CustomerDomain> _customerHandler;

        public CustomerController(IBaseHandler<CustomerDomain> customerHandler)
        {
            _customerHandler = customerHandler;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(_customerHandler.GetAll().Select(CustomerViewModelFactory.Create));
        }

        // GET: Customer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerViewModel customerViewModel = _customerHandler.GetById(id.Value).CreateCustomerViewModel();
            if (customerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(customerViewModel);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                _customerHandler.Add(customerViewModel.CreateCustomerDomain());
                _customerHandler.Commit();
                return RedirectToAction("Index");
            }
            return View(customerViewModel);
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerViewModel customerViewModel = _customerHandler.GetById(id.Value).CreateCustomerViewModel();

            if (customerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(customerViewModel);
        }

        // POST: Customer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                _customerHandler.Update(customerViewModel.CreateCustomerDomain());
                _customerHandler.Commit();
                return RedirectToAction("Index");
            }
            return View(customerViewModel);
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerViewModel customerViewModel = _customerHandler.GetById(id.Value).CreateCustomerViewModel();

            if (customerViewModel == null)
            {
                return HttpNotFound();
            }
            return View(customerViewModel);
        }

        // POST: Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _customerHandler.Delete(id);
            _customerHandler.Commit();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _customerHandler.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

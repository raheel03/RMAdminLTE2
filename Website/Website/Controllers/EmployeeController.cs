﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using DataLayer;

namespace Website.Controllers
{
    public class EmployeeController : Controller
    {
        private CompanyRepository repository;

        // GET: EmployeeController
        public ActionResult Index()
        {
            repository = new CompanyRepository();

            IEnumerable<Employee> employeeList = repository.Employees.ToList();

            return View(employeeList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return PartialView(new Employee());
        }

        // POST: EmployeeController/Create
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }

                if (repository == null)
                {
                    repository = new CompanyRepository();
                }

                repository.Employees.Add(employee);
                repository.SaveChanges();

                return PartialView(new Employee());
            }
            catch
            {
                return View(new Employee());
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

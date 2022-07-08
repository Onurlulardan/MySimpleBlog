﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySimpleBlog.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var CategoryValues = cm.GetAll();
            return View(CategoryValues);
        }

        public PartialViewResult BlogDetailsCategoryList()
        {
            return PartialView();
        }
    }
}
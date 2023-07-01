﻿using AspNetCore5_blogsite.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace AspNetCore5_blogsite.Controllers
{
	[AllowAnonymous]
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult WriterProfile()
		{
			return View();
		}
		public IActionResult WriterMail()
		{
			return View();
		}
        public IActionResult Test()
        {
            return View();
        }
		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
		[HttpGet]
        public IActionResult WriterEditProfile()
        {
			var writervalues = wm.TGetById(1);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
			WriterValidator wl = new WriterValidator();
			ValidationResult results = wl.Validate(p);
			if (results.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
                foreach (var item in results.Errors)
                {
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
			return View();
        }
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if(p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location,FileMode.Create);
                p.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
			w.WriterMail = p.WriterMail;
			w.WriterName = p.WriterName;
			w.WriterPassword = p.WriterPassword;
			w.WriterStatus = true;
			w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}

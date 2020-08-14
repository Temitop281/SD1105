using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationDailyBlogger.Models;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationDailyBlogger.Controllers

{
    public class Blogcontroller : Controller

    {
        private Blogcontext _context;

        public Blogcontroller(Blogcontext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult List()
        {
            IEnumerable<BlogPost> posts = _context.blogpost.ToList<BlogPost>();

            return View(posts);
        }


        public IActionResult New()
        {
            BlogPost blogPost = new BlogPost();

            return View(blogPost);

        }




        public IActionResult Create()
        {
            //created but not setup yet.


            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("blogTitle,content,blogDate")] BlogPost blog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(blog);
                _context.SaveChanges();
                return RedirectToAction(nameof(List));
            }
            return View(blog);

        }


    }


}



    

            

using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace BulkyBookWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }

    //GET
    public IActionResult Create()
    {
        return View();
    }

    //Post
    [HttpPost] //want to add post
    [ValidateAntiForgeryToken] // for validation
    public IActionResult Create(Category Obj)
    {
        if(Obj.Name == Obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name", "The Displayorder cannot exactly match the name");
        }
        if (ModelState.IsValid)
        {
            _db.Categories.Add(Obj); //add changes or data
            _db.SaveChanges(); // save data
            TempData["success"] = "Category created successfully.";
            return RedirectToAction("Index");
        }
        return View(Obj);
        
    }
    //GET
    public IActionResult Edit(int? id)
    {
        if(id == null || id == 0)
        {
            return NotFound();
        }
        var categoryFromDb = _db.Categories.Find(id);
        //different types
        //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.Id == id); 
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

        if(categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }

    //Post
    [HttpPost] //want to add post
    [ValidateAntiForgeryToken] // for validation
    public IActionResult Edit(Category Obj)
    {
        if (Obj.Name == Obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("name", "The Displayorder cannot exactly match the name");
        }
        if (ModelState.IsValid)
        {
            _db.Categories.Update(Obj); //add changes or data
            _db.SaveChanges(); // save data
            TempData["success"] = "Category updated successfully.";
            return RedirectToAction("Index");
        }
        return View(Obj);

    }

    //GET
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }
        var categoryFromDb = _db.Categories.Find(id);
        //different types
        //var categoryFromDbFirst = _db.Categories.FirstOrDefault(u => u.Id == id); 
        //var categoryFromDbSingle = _db.Categories.SingleOrDefault(u => u.Id == id);

        if (categoryFromDb == null)
        {
            return NotFound();
        }
        return View(categoryFromDb);
    }

    //Post
    [HttpPost,ActionName("Delete")] 
    [ValidateAntiForgeryToken] 
    public IActionResult DeletePOST(int? id)
    {
        var obj = _db.Categories.Find(id);
        if(obj == null)
        {
            return NotFound();
        }
        
            _db.Categories.Remove(obj); //add changes or data
            _db.SaveChanges(); // save data
            TempData["success"] = "Category deleted successfully.";
        return RedirectToAction("Index");
        
       

    }
}

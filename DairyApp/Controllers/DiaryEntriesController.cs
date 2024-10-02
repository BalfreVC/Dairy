using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public DiaryEntriesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry diaryEntry)
        {
            //Server side validation to avoid undesired inyection
            DiaryEntry.ValidateDiaryEntry(diaryEntry, this);
            
            if (ModelState.IsValid)
            {
                _dbContext.DiaryEntries.Add(diaryEntry);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "DiaryEntries");
            }

            return View(diaryEntry);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0 ) {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _dbContext.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry diaryEntry)
        {
            //Server side validation to avoid undesired inyection
            DiaryEntry.ValidateDiaryEntry(diaryEntry, this);

            if (ModelState.IsValid)
            {
                _dbContext.DiaryEntries.Update(diaryEntry);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "DiaryEntries");
            }

            return View(diaryEntry);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _dbContext.DiaryEntries.Find(id);
            if (diaryEntry == null)
            {
                return NotFound();
            }
            return View(diaryEntry);
        }

        [HttpPost]
        [ActionName("DeletionConfirmed")]
        public IActionResult Delete(DiaryEntry diaryEntry)
        {
            _dbContext.DiaryEntries.Remove(diaryEntry);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "DiaryEntries");
        }

        public IActionResult Index()
        {
            List<DiaryEntry> diaryEntriesList = _dbContext.DiaryEntries.ToList();
            return View(diaryEntriesList);
        }
    }
}

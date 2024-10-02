using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DairyApp.Models;

public class DiaryEntry
{
    /*
     [Key] se usa si el nombre no es consistente con los aceptados
     Aceptados: 
        Id
        <ClassName>Id
     */
    public int Id { get; set; }
    [Required(ErrorMessage = "Please add a Title!")]
    //[StringLength(150, MinimumLength = 5,
    //    ErrorMessage = "Title must be between 5 and 150 characters.")]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public DateTime CreationDate { get; set; } = DateTime.Now;

    public DiaryEntry()
    {
        
    }

    public DiaryEntry(int id, string title, string description, DateTime creationDate)
    {
        Id = id;
        Title = title;
        Description = description;
        CreationDate = creationDate;
    }

    public static void ValidateDiaryEntry(DiaryEntry diaryEntry, ControllerBase controllerBase) {
        if (diaryEntry.Title.Length < 3)
        {
            controllerBase.ModelState.AddModelError("Title", "Title is too short!");
        }
    }

}

using System;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models;

public class DiaryEntry
{
    // [Key] - EF Core will automatically use Id as the primary key
    public int Id { get; set; }
    [Required(ErrorMessage = "Please enter a title")]
    // [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Please fill in your content")]
    public string Content { get; set; } = string.Empty;
    [Required(ErrorMessage = "Please choose a date")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;







}

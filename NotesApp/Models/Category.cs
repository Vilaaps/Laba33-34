using System.ComponentModel.DataAnnotations;
namespace NotesApp.Models;

public class Category {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Note> Notes { get; set; } = new();


    [Required(ErrorMessage = "Название категории обязательно")]
    [MaxLength(100, ErrorMessage = "Название не должно превышать 100 символов")]
    public string Name { get; set; } = string.Empty;


    [MaxLength(500, ErrorMessage = "Описание не должно превышать 500 символов")]
    public string Description { get; set; } = string.Empty;


    [MaxLength(7)]
    public string Color { get; set; } = "#3498db";


    [Required(ErrorMessage = "Заголовок заметки обязателен")]
    [MaxLength(200, ErrorMessage = "Заголовок не должен превышать 200 символов")]
    public string Title { get; set; } = string.Empty;


    [MaxLength(5000, ErrorMessage = "Содержимое не должно превышать 5000 символов")]
    public string Content { get; set; } = string.Empty;


    [Range(1, 5, ErrorMessage = "Приоритет должен быть от 1 до 5")]
    public int Priority { get; set; } = 3;
}

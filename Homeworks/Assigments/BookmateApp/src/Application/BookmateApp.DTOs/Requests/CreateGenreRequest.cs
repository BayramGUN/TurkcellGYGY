using System.ComponentModel.DataAnnotations;

namespace BookmateApp.DTOs.Requests;

public class CreateGenreRequest
{
    [Required]
    [MaxLength(20)]
    public string? Name { get; set; }
}
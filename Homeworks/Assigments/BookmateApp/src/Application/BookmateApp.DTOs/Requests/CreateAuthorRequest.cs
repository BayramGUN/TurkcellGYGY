using System.ComponentModel.DataAnnotations;

namespace BookmateApp.DTOs.Requests;

public class CreateAuthorRequest
{
    [Required]
    [MaxLength(35)]
    public string? Firstname { get; set; } 
    [Required]
    public string? Lastname { get; set; } 
    [MaxLength(350)]
    public string? Info { get; set; } 
}
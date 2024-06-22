using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required] [MaxLength(50)] 
    public string Username { get; set; } = string.Empty;
    
    [Required]
    [StringLength(30, MinimumLength = 10)]
    public string Password { get; set; } = string.Empty;
}
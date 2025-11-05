using System.ComponentModel.DataAnnotations.Schema;

namespace JobSolutions.Models;

public class Notification
{
    public int Id { get; set; }
    [ForeignKey("UserModel")]
    public int UserId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation property
    public virtual UserModel? User { get; set; }
}

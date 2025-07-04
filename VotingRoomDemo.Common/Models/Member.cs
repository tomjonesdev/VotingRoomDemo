using System.ComponentModel.DataAnnotations;

namespace VotingRoomDemo.Common.Models;

public class Member
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
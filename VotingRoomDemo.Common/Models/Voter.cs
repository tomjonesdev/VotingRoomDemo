using VotingRoomDemo.Common.Enums;

namespace VotingRoomDemo.Common.Models;

public class Voter : Member
{
    public VoterType Type { get; set; }
}

using Xunit;
using MergingtonHighSchool.Models;

namespace MergingtonHighSchool.Tests;

public class ActivityTests
{
    [Fact]
    public void Activity_Should_Initialize_With_Correct_Values()
    {
        // Arrange
        var activity = new Activity
        {
            Description = "Test Activity",
            Schedule = "Monday 3:00 PM",
            MaxParticipants = 20,
            Participants = new List<string>()
        };

        // Act
        var participantCount = activity.Participants.Count;

        // Assert
        Assert.Equal(0, participantCount);
        Assert.Equal("Test Activity", activity.Description);
        Assert.Equal(20, activity.MaxParticipants);
    }

    [Fact]
    public void Activity_Should_Add_Participant()
    {
        // Arrange
        var activity = new Activity
        {
            Description = "Chess Club",
            Schedule = "Friday 3:30 PM",
            MaxParticipants = 12,
            Participants = new List<string>()
        };

        // Act
        activity.Participants.Add("student@mergington.edu");

        // Assert
        Assert.Single(activity.Participants);
        Assert.Contains("student@mergington.edu", activity.Participants);
    }
}
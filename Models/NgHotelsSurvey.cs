using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class NgHotelsSurvey
{
    public long Id { get; set; }

    public string? HearAboutRestaurant { get; set; }

    public string? VisitOurRestaurant { get; set; }

    public string? ComebackToRestaurant { get; set; }

    public string? RecommendRestaurantToFriend { get; set; }

    public string? BetterServeYouInFuture { get; set; }

    public string? Feedback { get; set; }

    public string? LikedItemInMenu { get; set; }

    public string? DisLikedItemInMenu { get; set; }

    public string? WantedItemInMenu { get; set; }

    public string? MealSatisfactory { get; set; }

    public string? DietaryRestrictions { get; set; }

    public string? TodayServerName { get; set; }

    public string? ServiceExperience { get; set; }

    public string? ServiceSpeed { get; set; }

    public string? StaffMeetYourNeeds { get; set; }

    public string? OverallExperienceRate { get; set; }

    public string? MusicExperience { get; set; }

    public string? RateCleanlynessRooms { get; set; }

    public string? IsRestaurantFamilyfriendly { get; set; }

    public string? IsSeatsComfortable { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}

using ContosoTrips.Exception;
using ContosoTrips.Trip;
using ContosoTrips.User;
using FluentAssertions;
using System;
using System.Collections.Generic;
using Xunit;
using static FluentAssertions.FluentActions;

namespace TripServiceTests
{
    public class trip_service_should
    {
        private int ZERO_TRIPS = 0;
        private static User loggedInUser;
        private static User GUEST = null;
        private static User REGISTER_USER = new User();
        private static User UNUSED_USER = null;
        private static User ANOTHER_USER = new User();
        private static Trip TO_BARCELONA = new Trip();
        private static Trip TO_ZARAGOZA = new Trip();
        private TestableTripService tripService;

        public trip_service_should()
        {
            tripService = new TestableTripService();
        }

        [Fact]
        public void not_allow_to_get_trips_when_user_is_not_logged_in()
        {
            loggedInUser = GUEST;

            Invoking(() => tripService.GetTripsByUser(UNUSED_USER)).Should().Throw<UserNotLoggedInException>();
        }

        [Fact]
        public void not_allow_to_get_back_trips_when_users_are_not_fiends()
        {
            loggedInUser = REGISTER_USER;

            var notFriend = Builder.User
                .WithTrips(TO_BARCELONA, TO_ZARAGOZA)
                .WithFriends(ANOTHER_USER)
                .Build();

            var trips = tripService.GetTripsByUser(notFriend);

            trips.Should().HaveCount(ZERO_TRIPS);
        }

        [Fact]
        public void allow_to_get_back_trips_when_users_are_friends()
        {
            loggedInUser = REGISTER_USER;

            var friend = Builder.User
                .WithFriends(loggedInUser, ANOTHER_USER)
                .WithTrips(TO_BARCELONA, TO_ZARAGOZA)
                .Build();

            var trips = tripService.GetTripsByUser(friend);

            trips.Should().HaveCount(2);
        }

        private class TestableTripService : TripService
        {
            protected override User GetLoggedUser()
            {
                return loggedInUser;
            }

            protected override List<Trip> GetTripsBy(User user)
            {
                return user.Trips();
            }
        }
    }
}

using InversionOfControl_Exercise.Domain.Entities.DTOs;
using InversionOfControl_Exercise.Domain.Interfaces;
using InversionOfControl_Exercise.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace InversionOfControl_Exercise.Tests
{
    public class ServiceClubTest
    {
        /*
            Some would argue that using DI for testing services is unnecessary
            since Microsoft itself tests the DI, but here we are only using it as 
            a mean to instantiate the service. Makes for cleaner code and continues
            to use DI.
        */

        private readonly IServiceClub _clubCalculator;

        public ServiceClubTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<IServiceClub, ServiceClub>();

            var serviceProvider = services.BuildServiceProvider();

            _clubCalculator = serviceProvider.GetService<IServiceClub>();
        }

        [Fact]
        public void CalculatePercentage_OK()
        {
            // Arrange
            var clubDTO = new ClubDTO()
            {
                Name = "Test",
                GamesPlayed = 9,
                PointsEarned = 3
            };

            // Act
            var result = _clubCalculator.CalculatePercentage(clubDTO);

            // Assert
            Assert.Equal(11.111111111111111, result.Percentage);
        }
    }
}

using InversionOfControl_Exercise.Domain.Entities;
using InversionOfControl_Exercise.Domain.Entities.DTOs;
using InversionOfControl_Exercise.Domain.Interfaces;
using System;

namespace InversionOfControl_Exercise.Services
{
    public class ServiceClub : IServiceClub
    {
        public Club CalculatePercentage(ClubDTO clubDTO)
        {
            var percentage = (Convert.ToDouble(clubDTO.PointsEarned) / Convert.ToDouble(clubDTO.GamesPlayed * 3) * 100);

            return new Club
            {
                Name = clubDTO.Name,
                Percentage = percentage
            };
        }
    }
}

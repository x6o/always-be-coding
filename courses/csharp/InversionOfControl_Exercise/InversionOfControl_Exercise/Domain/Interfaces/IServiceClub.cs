using InversionOfControl_Exercise.Domain.Entities;
using InversionOfControl_Exercise.Domain.Entities.DTOs;

namespace InversionOfControl_Exercise.Domain.Interfaces
{
    public interface IServiceClub
    {
        Club CalculatePercentage(ClubDTO clubDTO);
    }
}

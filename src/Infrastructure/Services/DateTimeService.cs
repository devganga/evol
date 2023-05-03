using evol.Application.Common.Interfaces;

namespace evol.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}

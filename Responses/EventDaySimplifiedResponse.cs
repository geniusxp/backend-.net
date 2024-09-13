using geniusxp_backend_dotnet.Models;

namespace geniusxp_backend_dotnet.Responses
{
    public class EventDaySimplifiedResponse
    {
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public string? TransmissionUrl { get; set; }

        public static ICollection<EventDaySimplifiedResponse> From(ICollection<EventDay> eventDays)
        {
            return eventDays.Select(eventDay => new EventDaySimplifiedResponse
            {
                StartDate = eventDay.StartDate,
                EndDate = eventDay.EndDate,
                TransmissionUrl = eventDay.TransmissionUrl
            }).ToList();
        }
    }
}

using System;
using MediatR;

namespace TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQuery : IRequest<EventDetailsVM>
    {
        public Guid Id { get; set; }
    }
}

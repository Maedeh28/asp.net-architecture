using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailsQuery : IRequest<EventDetailsVM>
    {
        public Guid Id { get; set; }
    }
}

using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using TicketManagement.Application.Contracts.Persistence;
using TicketManagement.Domain.Entities;

namespace TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailsHandler : IRequestHandler<GetEventDetailsQuery, EventDetailsVM>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;
        public async Task<EventDetailsVM> Handle(GetEventDetailsQuery request, CancellationToken cancellationToken)
        {

            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailsDto = _mapper.Map<EventDetailsVM>(@event);
            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);
            eventDetailsDto.Category = _mapper.Map<CategoryDto>(category);
            return eventDetailsDto;

        }
    }
}

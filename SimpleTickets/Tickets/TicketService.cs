using System.Threading.Tasks;
using SimpleTickets.Models;
using SimpleTickets.Repositories;

namespace SimpleTickets.Services;

public class TicketService
{
    private readonly ITicketRepository _ticketRepository;

    public TicketService(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<List<Ticket>> ListTickets()
    {
        return await _ticketRepository.ListTicketsAsync();
    }
}
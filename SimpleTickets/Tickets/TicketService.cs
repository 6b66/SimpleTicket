using System.Threading.Tasks;
using SimpleTickets.Models;
using SimpleTickets.Repositories;

namespace SimpleTickets.Services;

public class TicketService
{
    private readonly ITicketRepository _userRepository;

    public TicketService(ITicketRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<Ticket>> ListTickets()
    {
        return await _userRepository.ListTicketsAsync();
    }
}
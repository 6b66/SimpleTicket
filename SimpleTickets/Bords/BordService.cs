using System.Threading.Tasks;
using SimpleTickets.Models;
using SimpleTickets.Repositories;

namespace SimpleTickets.Services;

public class BordService
{
    private readonly IBordRepository _bordRepository;

    public BordService(IBordRepository bordRepository)
    {
        _bordRepository = bordRepository;
    }

    public async Task<List<Bord>> ListBord()
    {
        return await _bordRepository.ListBordsAsync();
    }
}
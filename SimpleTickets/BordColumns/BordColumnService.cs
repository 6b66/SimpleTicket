using System.Threading.Tasks;
using SimpleTickets.Models;
using SimpleTickets.Repositories;

namespace SimpleTickets.Services;

public class BordColumnService
{
    private readonly IBordColumnRepository _bordColumnRepository;

    public BordColumnService(IBordColumnRepository bordColumnRepository)
    {
        _bordColumnRepository = bordColumnRepository;
    }

    public async Task<List<BordColumn>> ListBordColumn()
    {
        return await _bordColumnRepository.ListBordColumnsAsync();
    }
}
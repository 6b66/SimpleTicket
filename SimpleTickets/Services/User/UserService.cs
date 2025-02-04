using System.Threading.Tasks;
using SimpleTickets.Models;
using SimpleTickets.Repositories;

namespace SimpleTickets.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> ListUsers()
    {
        return await _userRepository.ListUsersAsync();
    }
}
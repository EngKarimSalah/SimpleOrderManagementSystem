using SimpleOrderManagementSystem.DTOs;

namespace SimpleOrderManagementSystem.Services
{
    public interface IUserService
    {
        int AddUser(UserInputDTO userInputDTO);
        string login(string email, string password);
    }
}
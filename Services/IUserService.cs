using SimpleOrderManagementSystem.DTOs;
using SimpleOrderManagementSystem.Models;

namespace SimpleOrderManagementSystem.Services
{
    public interface IUserService
    {
        int AddUser(UserInputDTO userInputDTO);
    }
}
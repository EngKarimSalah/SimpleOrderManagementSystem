using SimpleOrderManagementSystem.DTOs;
using SimpleOrderManagementSystem.Models;
using SimpleOrderManagementSystem.Repositories;
using System.Text;
using System.Security.Cryptography;


namespace SimpleOrderManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int AddUser(UserInputDTO userInputDTO)
        {
            string HashedPassword = PasswordHashing(userInputDTO.password);

            var user = new User
            {
                Name = userInputDTO.name,
                role = userInputDTO.role,
                Email = userInputDTO.email,
                Password = HashedPassword,
                CreatedAt = DateTime.Now,
            };

            return _userRepository.AddUser(user);

        }



        private string PasswordHashing(string password)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the input password to a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the hash to a string (hexadecimal representation)
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2")); // Converts each byte to a hex string
                }

                return hashString.ToString();

            }
        }
    }
}

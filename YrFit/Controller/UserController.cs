using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using YrFit.Model;

namespace YrFit.Controller
{
    class UserController
    {
        public ObservableCollection<User> Users { get; set; }
        AppDbContext db = new AppDbContext();

        
        public List<User> getUsers()
        {
            try
            {
                var users = db.Users.ToList(); 
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении пользователей: " + ex.Message);
                return null; 
            }
        }

        public (User, string error) CreateNewUser(string login, string password, string name, string surname, string email, string telephone, DateTime date)
        {
            try
            {
                if (db.Users.Any(item => item.Login == login))
                    return (null, "Логин уже занят");

                if (db.Users.Any(item => item.Email == email))
                    return (null, "Почта уже занята");

                if (db.Users.Any(item => item.PhoneNumber == telephone))
                    return (null, "Телефон уже занят");

                string projectPath = Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(projectPath).Parent.Parent.FullName + "\\Img\\UserAvatar.jpg";
                
                byte[] imageBytes = ConvertImageToByteArray(projectDirectory);

                User user = new User
                {
                    Login = login,
                    Password = password,
                    Email = email,
                    Name = name,
                    Surname = surname,
                    PhoneNumber = telephone,
                    BirthDate = date,
                    AvatarImg = imageBytes,
                    Role = Role.User,
                    HashedLogin = HashPassword(login)
                };
                db.Users.Add(user);
                db.SaveChanges();

                return (user, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании нового пользователя: " + ex.Message);
                return (null, null);
            }
        }

        public (User, string) SingIn(string login, string password, StringComparison comparisonType)
        {
            try
            {
                string hashedLogin = HashPassword(login);
                var user = db.Users.FirstOrDefault(x => x.HashedLogin.Equals(hashedLogin));

                if (user != null)
                {
                    if (string.Equals(user.Password, password, comparisonType))
                    {
                        return (user, null);
                    }
                    else
                    {
                        return (null, "Неверный пароль");
                    }
                }
                else
                {
                    return (null, "Такого пользователя не существует");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске пользователя: " + ex.Message);
                return (null, "Ошибка при поиске пользователя");
            }
        }


        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static byte[] ConvertImageToByteArray(string imagePath)
        {
            try
            {

                if (!File.Exists(imagePath))
                {
                    Console.WriteLine("Файл не найден.");
                    return null;
                }


                byte[] imageArray = File.ReadAllBytes(imagePath);
                return imageArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении изображения: {ex.Message}");
                return null;
            }
        }
    }
}

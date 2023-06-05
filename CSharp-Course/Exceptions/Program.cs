using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Exceptions
{
    public class Program
    {
        public static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            User user = new User();
            User user2 = new User();
            User user3 = new User();
            users.Add(user);
            users.Add(user2);
            users.Add(user3);

            foreach (var user1 in users)
            {
                Console.WriteLine($"Name: {user.Name}, Password: {user.Password}, Email: {user.Email}, ID: {user.Id}");
            }

        }
       
    }

    public class User : IUser
    {



        public User()
        {
            CreateUser();
        }


        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }


        public void CreateUser()
        {
            Console.WriteLine("Enter your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            Password = Console.ReadLine();
            Console.WriteLine("Enter your Email: ");
            Email = Console.ReadLine();


            var newUser = new User
            {
                Name = Name,
                Password = Password,
                Email = Email
            };


        }

    }

    public interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }



        void CreateUser();
    }
}
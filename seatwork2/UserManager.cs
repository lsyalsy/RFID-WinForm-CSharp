using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace seatwork2
{
    public class UserManager
    {
        private string _userFile;
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();
            string appPath = Application.StartupPath;
            string projectPath = Path.GetFullPath(Path.Combine(appPath, @"..\..\..\"));
            _userFile = Path.Combine(projectPath, "users.txt");
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(_userFile))
            {
                try
                {
                    var lines = File.ReadAllLines(_userFile);
                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                _users.Add(new User
                                {
                                    Username = parts[0],
                                    Password = parts[1]
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading users: " + ex.Message);
                }
            }
        }

        private void SaveUsers()
        {
            try
            {
                var lines = _users.Select(user => $"{user.Username},{user.Password}").ToArray();
                File.WriteAllLines(_userFile, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving users: " + ex.Message);
            }
        }

        public bool Register(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return false;

            if (_users.Any(user => user.Username == username))
                return false;

            _users.Add(new User { Username = username, Password = password });
            SaveUsers();
            return true;
        }

        public bool Login(string username, string password)
        {
            return _users.Any(user => user.Username == username && user.Password == password);
        }
    }

    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

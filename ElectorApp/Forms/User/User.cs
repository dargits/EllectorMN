using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectorApp.Models.User;

public class User
{
    public int ID { get; set; }
    public string Account { get; set; }
    public bool IsAdmin { get; set; }
    public string Password { get; set; }
    public String Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public User() { }

    public User(int iD, string account, bool isAdmin, String userName, string password)
    {
        ID = iD;
        Account = account;
        IsAdmin = isAdmin;
        Name = userName;
        Password = password;
    }
}

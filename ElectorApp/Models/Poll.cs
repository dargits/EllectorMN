using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectorApp.Models
{
    internal class Poll
    {
        int ID {  get; set; }
        string Title {  get; set; }
        string Description { get; set; }

        bool IsActive {  get; set; }

        DateTime CreateAt { get; set; }

        int UserID { get; set; }

        public Poll() { }

        public Poll(int iD, string title, string description, bool isActive, DateTime createAt, int userID)
        {
            ID = iD;
            Title = title;
            Description = description;
            IsActive = isActive;
            CreateAt = createAt;
            UserID = userID;
        }
    }
}

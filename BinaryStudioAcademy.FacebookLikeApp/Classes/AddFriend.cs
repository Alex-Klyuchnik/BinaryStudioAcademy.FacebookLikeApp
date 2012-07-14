using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy.FacebookLikeApp.Models;

namespace BinaryStudioAcademy.FacebookLikeApp.Classes
{
    public class AddFriend 
    {
        public void Add (User friend, User user)
        {
           user.friends.Add(friend);
        }

        public void Delete(User friend, User user)
        {
            user.friends.Remove(friend);
        }
    }
}
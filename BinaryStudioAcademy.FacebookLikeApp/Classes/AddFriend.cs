using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy.FacebookLikeApp.Models;

namespace BinaryStudioAcademy.FacebookLikeApp.Classes
{
    public class AddFriend 
    {
        private static void Add (User friend, User user)
        {
           user.friends.Add(friend);
        }

        public void Delete(User friend, User user)
        {
            user.friends.Remove(friend);
        }
        
        public void SendRequest(User friend, User user)
        {
            friend.requestedFriendship.Add(user);
        }
        
        public void AcceptRequest(User friend, User user)
        {
            Add(friend, user);
            Add(user,friend);
            user.requestedFriendship.Remove(friend);
        }

        public void DeclineRequest(User friend, User user)
        {
            user.requestedFriendship.Remove(friend);
        }
    }
}
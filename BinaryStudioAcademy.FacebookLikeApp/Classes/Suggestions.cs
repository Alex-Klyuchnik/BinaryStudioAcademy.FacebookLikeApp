using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudioAcademy.FacebookLikeApp.Models;

namespace BinaryStudioAcademy.FacebookLikeApp.Classes
{
    public class Suggestions
    {
        public void Accept()
        {
             throw new NotImplementedException();
        }

        public void RefusePermanently()
        {
            throw new NotImplementedException();
        }

        public void Renew(User user)
        {
            throw new NotImplementedException();
        }

        public IList<User> SearchFriendIntersection(User user)
        {
            //var friends = user.friends.AsEnumerable(); 
            throw new NotImplementedException();
        }

        public bool SearchForInterestIntersection(User user1, User user2)
        {
            var interest1 = user1.interests.AsQueryable();
            var interest2 = user2.interests.AsQueryable();
            var NumberOfInterestIntersection = 0;
            foreach (var x in interest1)
            {
                foreach (var y in interest2)
                {
                    if (x == y)
                    {
                        NumberOfInterestIntersection++;
                    }
                }
            }
            if (NumberOfInterestIntersection > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
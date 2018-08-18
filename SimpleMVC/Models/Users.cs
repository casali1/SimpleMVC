using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class Users
    {

        public List<UserModels> _userList = new List<UserModels>();

        public Users()
        {
            _userList.Add(new UserModels
            {
                FirstName = "aaa",
                LastName ="bbb",
                Address = "XXXXX",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("6/22/1976"),
                Salary = 40000
            });
            _userList.Add(new UserModels
            {
                FirstName = "ccc",
                LastName = "ddd",
                Address = "XXXXX",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("6/22/1976"),
                Salary = 40000
            });

            _userList.Add(new UserModels
            {
                FirstName = "eee",
                LastName = "fff",
                Address = "XXXXX",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("6/22/1976"),
                Salary = 40000
            });
        }

        public void CreateUser(UserModels userModel)
        {
            _userList.Add(userModel);
        }

        public void UpdateUser(UserModels userModel)
        {
            foreach (UserModels user in _userList)
            {
                if(user.Email == userModel.Email)
                {
                    _userList.Remove(user);
                    _userList.Add(userModel);
                    break;
                }
            }
        }
    }
}
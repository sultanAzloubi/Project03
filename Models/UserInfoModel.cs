﻿namespace ASP.NETCoreWebApplication.Models
{
    public class UserInfoModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        
        public UsersModel Users { get; set; }
    }
}
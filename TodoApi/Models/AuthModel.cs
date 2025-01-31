﻿namespace Auth.Models
{
    public class AuthModel
    {
        public string Message { get; set; }
        public string UserName { get; set; }
        public bool IsAuth { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}

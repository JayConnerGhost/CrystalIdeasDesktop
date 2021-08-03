using System;
using Windows.Management.Deployment;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Crystal_Ideas_Desktop.Models
{
    public class RegisterProfileModel: ObservableObject,IRegisterProfileModel
    {
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
    }
}
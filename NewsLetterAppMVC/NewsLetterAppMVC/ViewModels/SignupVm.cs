using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsLetterAppMVC.Controllers;

namespace NewsLetterAppMVC.ViewModels
{
    public class SignupVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

    }
}
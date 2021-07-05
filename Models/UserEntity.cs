

using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Highfield.Models
{
    public class UserEntity
    {
        public string id { get; set; } //wanted to us GUIDs but VSCode is a nightmare
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }
        public string favouriteColour { get; set; }
    }
}
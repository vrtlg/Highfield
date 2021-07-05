
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Highfield.Models
{
    public class AgePlusTwenty
    {
        public string userId { get; set; } //wanted to us GUIDs but VSCode is a nightmare
        public int originalAge { get; set; }
        public int agePlusTwenty { get; set; }
    }
}
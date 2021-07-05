
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Highfield.Models
{
    public class Response
    {
        public List<UserEntity> users { get; set; }
        public List<AgePlusTwenty> ages { get; set; }
        public List<TopColours> topColours { get; set; }
    }
}
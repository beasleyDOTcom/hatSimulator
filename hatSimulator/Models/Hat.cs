using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hatSimulator.Models
{
    public class Hat
    {
        public int HatID {get; set;}
        public List<Phone> PhoneNumbers {get; set;}
    }
}
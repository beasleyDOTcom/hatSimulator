using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace hatSimulator.Models
{
    public class Phone
    {
        public int ID {get; set;}
        public string Number {get; set;}
        // public string? Name {get; set;}
        // public string? Message{get; set;}
        // public string? Roomcode{get; set;}
    }
}

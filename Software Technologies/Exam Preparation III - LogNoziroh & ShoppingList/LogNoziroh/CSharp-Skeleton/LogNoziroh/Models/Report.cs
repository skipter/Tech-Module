﻿namespace LogNoziroh.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Report
    {
        //TODO
        [Key]
        public int Id { get; set; }

        public string Status { get; set; }

        public string Message { get; set; }

        public string Origin { get; set; }
    }
}

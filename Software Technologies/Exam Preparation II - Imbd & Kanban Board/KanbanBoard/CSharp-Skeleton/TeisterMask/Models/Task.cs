﻿namespace TeisterMask.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Task
    {

        //TODO

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Status { get; set; }

    }
}

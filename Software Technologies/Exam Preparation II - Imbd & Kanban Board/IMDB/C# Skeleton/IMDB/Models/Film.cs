﻿namespace IMDB.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Film
    {
        // TODO

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }
    }
}

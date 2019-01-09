namespace SoftUniBabies.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Baby
    {
        //TODO

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }
    }
}

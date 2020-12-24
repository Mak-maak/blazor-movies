using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovie.Entities
{
    public class PersonModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public string Picture { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is PersonModel p2)
                return ID == p2.ID;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
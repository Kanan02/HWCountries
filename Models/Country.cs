using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class Country
    {

        public int Id { get; set; }

        public string CountryName { get; set; }
        public virtual ICollection<Participant> Participants { get; set; } = new List<Participant>();
        
    }
}

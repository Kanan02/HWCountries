using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class Participant
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public Sport Sport { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<ParticipantMedal> ParticipantMedals { get; set; }
    }
}

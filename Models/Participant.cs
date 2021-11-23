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
        public virtual Sport Sport { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<ParticipantMedal> ParticipantMedals { get; set; }=new List<ParticipantMedal>();
    }
}

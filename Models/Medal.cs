using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class Medal
    {

        public int Id { get; set; }
        public string MedalType { get; set; }
        public virtual ICollection<ParticipantMedal> ParticipantMedals { get; set; }
    }
}

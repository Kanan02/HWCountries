using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class ParticipantMedal
    {
        public int ParticipantId { get; set; }
        public virtual Participant Participant { get; set; }
        public int MedalId { get; set; }
        public virtual Medal Medal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class ParticipantMedal
    {
        public int ParticipantId { get; set; }
        public Participant Participant { get; set; }
        public int MedalId { get; set; }
        public Medal Medal { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodefirstCountry.Models
{
    public class Sport
    {
        public int Id { get; set; }

        public string SportName { get; set; }
        public virtual List<Participant> Participants { get; set; }=new List<Participant>();
    }
}

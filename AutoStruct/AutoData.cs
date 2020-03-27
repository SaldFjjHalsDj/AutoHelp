using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStruct.Data
{
    [Serializable]
    public class AutoData
    {
        public string Mark { get; set; }

        public DateTime DateOfIssue { get; set; }

        public double Price { get; set; }

        public DateTime DateOfAnnouncement { get; set; }

        public string Source { get; set; }

        public string RegistrationNumber { get; set; }

    }
}

using CommunityProApp.Enums;
using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public BloodGroup Group { get; set; }

        public Genotype Genotype { get; set; }

        public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}

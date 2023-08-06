using CommunityProApp.Enums;
using System;
using System.Collections.Generic;

namespace CommunityProApp.Entities
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string LicenseNumber { get; set; }


        public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}

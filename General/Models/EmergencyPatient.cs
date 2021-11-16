using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace General.Models
{
    public class EmergencyPatient
    {
        public EmergencyPatient()
        {
        }

        public int idEmergencyPatients { get; set; }

        public string documentNumberEmergencyPatients { get; set; }

        public string namesEmergencyPatients { get; set; }

        public string lastNamesEmergencyPatients { get; set; }

        public int ageEmergencyPatients { get; set; }

        public string addressEmergencyPatients { get; set; }

        public string genderEmergencyPatients { get; set; }

        public int weightEmergencyPatients { get; set; }

        public int heightEmergencyPatients { get; set; }

        public int smokerEmergencyPatients { get; set; }

        public int dietEmergencyPatients { get; set; }

        public double heightWeightRatioEmergencyPatients { get; set; }

        public double priorityEmergencyPatients { get; set; }

        public double riskEmergencyPatients { get; set; }

        public string statusEmergencyPatients { get; set; }

    }
}

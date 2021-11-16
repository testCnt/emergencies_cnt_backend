using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using General.Models;

namespace General.Maps
{
    public class EmergencyPatientMap
    {
        public EmergencyPatientMap(EntityTypeBuilder<EmergencyPatient> entityBuilder)

        {
            entityBuilder.HasKey(x => x.idEmergencyPatients);
            entityBuilder.ToTable("emergencyPatients");

            entityBuilder.Property(x => x.idEmergencyPatients).HasColumnName("idEmergencyPatients");
            entityBuilder.Property(x => x.documentNumberEmergencyPatients).HasColumnName("documentNumberEmergencyPatients");
            entityBuilder.Property(x => x.namesEmergencyPatients).HasColumnName("namesEmergencyPatients");
            entityBuilder.Property(x => x.lastNamesEmergencyPatients).HasColumnName("lastNamesEmergencyPatients");
            entityBuilder.Property(x => x.ageEmergencyPatients).HasColumnName("ageEmergencyPatients");
            entityBuilder.Property(x => x.addressEmergencyPatients).HasColumnName("addressEmergencyPatients");
            entityBuilder.Property(x => x.weightEmergencyPatients).HasColumnName("weightEmergencyPatients");
            entityBuilder.Property(x => x.heightEmergencyPatients).HasColumnName("heightEmergencyPatients");
            entityBuilder.Property(x => x.smokerEmergencyPatients).HasColumnName("smokerEmergencyPatients");
            entityBuilder.Property(x => x.dietEmergencyPatients).HasColumnName("dietEmergencyPatients");
            entityBuilder.Property(x => x.heightWeightRatioEmergencyPatients).HasColumnName("heightWeightRatioEmergencyPatients");
            entityBuilder.Property(x => x.priorityEmergencyPatients).HasColumnName("priorityEmergencyPatients");
            entityBuilder.Property(x => x.riskEmergencyPatients).HasColumnName("riskEmergencyPatients");
            entityBuilder.Property(x => x.statusEmergencyPatients).HasColumnName("statusEmergencyPatients");
        }
    }
}

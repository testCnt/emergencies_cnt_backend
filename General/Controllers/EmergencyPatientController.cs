using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using General.Models;
using System.Web.Http.Cors;

namespace General.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [DisableCors]
    public class EmergencyPatientController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public EmergencyPatientController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public object GetEmergencyPatient()
        {
            return _context.EmergencyPatient.Where(b => b.statusEmergencyPatients.Equals("PENDING")).Select((c) => new
            {
                idEmergencyPatients                 = c.idEmergencyPatients,
                documentNumberEmergencyPatients     = c.documentNumberEmergencyPatients,
                namesEmergencyPatients              = c.namesEmergencyPatients,
                lastNamesEmergencyPatients          = c.lastNamesEmergencyPatients,
                ageEmergencyPatients                = c.ageEmergencyPatients,
                addressEmergencyPatients            = c.addressEmergencyPatients,
                genderEmergencyPatients             = c.genderEmergencyPatients,
                heightEmergencyPatients             = c.heightEmergencyPatients,
                weightEmergencyPatients             = c.weightEmergencyPatients,
                smokerEmergencyPatients             = c.smokerEmergencyPatients,
                dietEmergencyPatients               = c.dietEmergencyPatients,
                heightWeightRatioEmergencyPatients  = c.heightWeightRatioEmergencyPatients,
                priorityEmergencyPatients           = c.priorityEmergencyPatients,
                riskEmergencyPatients               = c.riskEmergencyPatients,
                statusEmergencyPatients             = c.statusEmergencyPatients
            }).ToList();
        }

        [HttpGet]
        [Route("HigherPrioritySmokingPatientWithPendingStatus")]
        public object GetHigherPrioritySmokingPatientWithPendingStatus()
        {
            return _context.EmergencyPatient.Where(
                    b =>
                    b.statusEmergencyPatients.Equals("PENDING")
                    && b.smokerEmergencyPatients >= 0
                )
                .OrderByDescending(b => b.priorityEmergencyPatients)
                .Take(1)
                .Select((c) => new
                {
                    idEmergencyPatients = c.idEmergencyPatients,
                    documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                    namesEmergencyPatients = c.namesEmergencyPatients,
                    lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                    ageEmergencyPatients = c.ageEmergencyPatients,
                    addressEmergencyPatients = c.addressEmergencyPatients,
                    genderEmergencyPatients = c.genderEmergencyPatients,
                    weightEmergencyPatients = c.weightEmergencyPatients,
                    heightEmergencyPatients = c.heightEmergencyPatients,
                    smokerEmergencyPatients = c.smokerEmergencyPatients,
                    dietEmergencyPatients = c.dietEmergencyPatients,
                    heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                    priorityEmergencyPatients = c.priorityEmergencyPatients,
                    riskEmergencyPatients = c.riskEmergencyPatients,
                    statusEmergencyPatients = c.statusEmergencyPatients
                }).ToList();
        }

        [HttpGet]
        [Route("YoungerPatientWithPendingStatus")]
        public object GetYoungerPatientWithPendingStatus()
        {
            return _context.EmergencyPatient.Where(
                    b =>
                    b.statusEmergencyPatients.Equals("PENDING")
                    && b.smokerEmergencyPatients >= 0
                )
                .OrderBy(b => b.ageEmergencyPatients)
                .Take(1)
                .Select((c) => new
                {
                    idEmergencyPatients = c.idEmergencyPatients,
                    documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                    namesEmergencyPatients = c.namesEmergencyPatients,
                    lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                    ageEmergencyPatients = c.ageEmergencyPatients,
                    addressEmergencyPatients = c.addressEmergencyPatients,
                    genderEmergencyPatients = c.genderEmergencyPatients,
                    weightEmergencyPatients = c.weightEmergencyPatients,
                    heightEmergencyPatients = c.heightEmergencyPatients,
                    smokerEmergencyPatients = c.smokerEmergencyPatients,
                    dietEmergencyPatients = c.dietEmergencyPatients,
                    heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                    priorityEmergencyPatients = c.priorityEmergencyPatients,
                    riskEmergencyPatients = c.riskEmergencyPatients,
                    statusEmergencyPatients = c.statusEmergencyPatients
                }).ToList();
        }

        [HttpGet]
        [Route("OlderPatientWithPendingStatus")]
        public object GetOlderPatientWithPendingStatus()
        {
            return _context.EmergencyPatient.Where(
                    b =>
                    b.statusEmergencyPatients.Equals("PENDING")
                    && b.smokerEmergencyPatients >= 0
                )
                .OrderByDescending(b => b.ageEmergencyPatients)
                .Take(1)
                .Select((c) => new
                {
                    idEmergencyPatients = c.idEmergencyPatients,
                    documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                    namesEmergencyPatients = c.namesEmergencyPatients,
                    lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                    ageEmergencyPatients = c.ageEmergencyPatients,
                    addressEmergencyPatients = c.addressEmergencyPatients,
                    genderEmergencyPatients = c.genderEmergencyPatients,
                    weightEmergencyPatients = c.weightEmergencyPatients,
                    heightEmergencyPatients = c.heightEmergencyPatients,
                    smokerEmergencyPatients = c.smokerEmergencyPatients,
                    dietEmergencyPatients = c.dietEmergencyPatients,
                    heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                    priorityEmergencyPatients = c.priorityEmergencyPatients,
                    riskEmergencyPatients = c.riskEmergencyPatients,
                    statusEmergencyPatients = c.statusEmergencyPatients
                }).ToList();
        }


        [HttpGet]
        [Route("PatientsByRisk")]
        public object GetPatientsByRisk()
        {
            return _context.EmergencyPatient.Where(b => b.statusEmergencyPatients.Equals("PENDING"))
                .OrderByDescending(b => b.riskEmergencyPatients)
                .Select((c) => new
            {
                idEmergencyPatients = c.idEmergencyPatients,
                documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                namesEmergencyPatients = c.namesEmergencyPatients,
                lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                ageEmergencyPatients = c.ageEmergencyPatients,
                addressEmergencyPatients = c.addressEmergencyPatients,
                genderEmergencyPatients = c.genderEmergencyPatients,
                weightEmergencyPatients = c.weightEmergencyPatients,
                heightEmergencyPatients = c.heightEmergencyPatients,
                smokerEmergencyPatients = c.smokerEmergencyPatients,
                dietEmergencyPatients = c.dietEmergencyPatients,
                heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                priorityEmergencyPatients = c.priorityEmergencyPatients,
                riskEmergencyPatients = c.riskEmergencyPatients,
                statusEmergencyPatients = c.statusEmergencyPatients
            }).ToList();
        }

        [HttpGet]
        [Route("PatientsByPriority")]
        public object GetPatientsByPriority()
        {
            return _context.EmergencyPatient.Where(b => b.statusEmergencyPatients.Equals("PENDING"))
                .OrderByDescending(b => b.priorityEmergencyPatients)
                .Select((c) => new
                {
                    idEmergencyPatients = c.idEmergencyPatients,
                    documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                    namesEmergencyPatients = c.namesEmergencyPatients,
                    lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                    ageEmergencyPatients = c.ageEmergencyPatients,
                    addressEmergencyPatients = c.addressEmergencyPatients,
                    genderEmergencyPatients = c.genderEmergencyPatients,
                    weightEmergencyPatients = c.weightEmergencyPatients,
                    heightEmergencyPatients = c.heightEmergencyPatients,
                    smokerEmergencyPatients = c.smokerEmergencyPatients,
                    dietEmergencyPatients = c.dietEmergencyPatients,
                    heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                    priorityEmergencyPatients = c.priorityEmergencyPatients,
                    riskEmergencyPatients = c.riskEmergencyPatients,
                    statusEmergencyPatients = c.statusEmergencyPatients
                }).ToList();
        }

        [HttpGet("{documentNumberEmergencyPatients}")]
        public ActionResult<object> GetEmergencyPatient(string documentNumberEmergencyPatients)
        {
            return _context.EmergencyPatient.Where(b => b.documentNumberEmergencyPatients == documentNumberEmergencyPatients).Select((c) => new
            {
                idEmergencyPatients = c.idEmergencyPatients,
                documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                namesEmergencyPatients = c.namesEmergencyPatients,
                lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                ageEmergencyPatients = c.ageEmergencyPatients,
                addressEmergencyPatients = c.addressEmergencyPatients,
                genderEmergencyPatients = c.genderEmergencyPatients,
                weightEmergencyPatients = c.weightEmergencyPatients,
                heightEmergencyPatients = c.heightEmergencyPatients,
                smokerEmergencyPatients = c.smokerEmergencyPatients,
                dietEmergencyPatients = c.dietEmergencyPatients,
                heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                priorityEmergencyPatients = c.priorityEmergencyPatients,
                riskEmergencyPatients = c.riskEmergencyPatients,
                statusEmergencyPatients = c.statusEmergencyPatients
            }).ToList();
        }

        [HttpPut("{idEmergencyPatients}")]
        public async Task<ActionResult<EmergencyPatient>> UpdateEmergencyPatient(int idEmergencyPatients, EmergencyPatient emergencyPatient)
        {
            if (idEmergencyPatients != emergencyPatient.idEmergencyPatients)
            {
                return BadRequest();
            }

            var emergencyPatientDB = await _context.EmergencyPatient.FindAsync(idEmergencyPatients);
            if (emergencyPatientDB == null)
            {
                return NotFound();
            }

            emergencyPatientDB.documentNumberEmergencyPatients      = emergencyPatient.documentNumberEmergencyPatients;
            emergencyPatientDB.namesEmergencyPatients               = emergencyPatient.namesEmergencyPatients;
            emergencyPatientDB.lastNamesEmergencyPatients           = emergencyPatient.lastNamesEmergencyPatients;
            emergencyPatientDB.ageEmergencyPatients                 = emergencyPatient.ageEmergencyPatients;
            emergencyPatientDB.addressEmergencyPatients             = emergencyPatient.addressEmergencyPatients;
            emergencyPatientDB.genderEmergencyPatients              = emergencyPatient.genderEmergencyPatients;
            emergencyPatientDB.weightEmergencyPatients              = emergencyPatient.weightEmergencyPatients;
            emergencyPatientDB.heightEmergencyPatients              = emergencyPatient.heightEmergencyPatients;
            emergencyPatientDB.smokerEmergencyPatients              = emergencyPatient.smokerEmergencyPatients;
            emergencyPatientDB.dietEmergencyPatients                = emergencyPatient.dietEmergencyPatients;
            emergencyPatientDB.heightWeightRatioEmergencyPatients   = calculateheightWeightRatio(emergencyPatient);
            emergencyPatientDB.priorityEmergencyPatients            = calculatePriority(emergencyPatient);
            emergencyPatientDB.riskEmergencyPatients                = calculateRisk(emergencyPatient);
            emergencyPatientDB.statusEmergencyPatients              = emergencyPatient.statusEmergencyPatients;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception) when (exist(emergencyPatient.documentNumberEmergencyPatients, "PENDING") || exist(emergencyPatient.documentNumberEmergencyPatients, "ATTENDED"))
            {
                return NotFound();
            }

            return emergencyPatient_ToDTO(emergencyPatientDB);
        }

        [HttpPut("ChangeStatusToAttended/{idEmergencyPatients}")]
        public async Task<ActionResult<EmergencyPatient>> UpdateEmergencyPatientStatusToAttended(int idEmergencyPatients)
        {

            var emergencyPatientDB = await _context.EmergencyPatient.FindAsync(idEmergencyPatients);
            if (emergencyPatientDB == null)
            {
                return NotFound();
            }

            emergencyPatientDB.statusEmergencyPatients = "ATTENDED";

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return NotFound();
            }

            return emergencyPatient_ToDTO(emergencyPatientDB);
        }

        [HttpPost]
        public async Task<ActionResult<object>> CreateEmergencyPatient(EmergencyPatient emergencyPatient)
        {
            if (exist(emergencyPatient.documentNumberEmergencyPatients, "PENDING"))
            {
                return new
                {
                    message = "this user already exists with pending status"
                };
            }
            emergencyPatient.statusEmergencyPatients            = "PENDING";
            emergencyPatient.heightWeightRatioEmergencyPatients = calculateheightWeightRatio(emergencyPatient);
            emergencyPatient.priorityEmergencyPatients          = calculatePriority(emergencyPatient);
            emergencyPatient.riskEmergencyPatients              = calculateRisk(emergencyPatient);
            
            var emergencyPatientAux = new EmergencyPatient
            {
                documentNumberEmergencyPatients     = emergencyPatient.documentNumberEmergencyPatients,
                namesEmergencyPatients              = emergencyPatient.namesEmergencyPatients,
                lastNamesEmergencyPatients          = emergencyPatient.lastNamesEmergencyPatients,
                ageEmergencyPatients                = emergencyPatient.ageEmergencyPatients,
                addressEmergencyPatients            = emergencyPatient.addressEmergencyPatients,
                genderEmergencyPatients             = emergencyPatient.genderEmergencyPatients,
                heightEmergencyPatients             = emergencyPatient.heightEmergencyPatients,
                weightEmergencyPatients             = emergencyPatient.weightEmergencyPatients,
                smokerEmergencyPatients             = emergencyPatient.smokerEmergencyPatients,
                dietEmergencyPatients               = emergencyPatient.dietEmergencyPatients,
                heightWeightRatioEmergencyPatients  = emergencyPatient.heightWeightRatioEmergencyPatients,
                priorityEmergencyPatients           = emergencyPatient.priorityEmergencyPatients,
                riskEmergencyPatients               = emergencyPatient.riskEmergencyPatients,
                statusEmergencyPatients             = emergencyPatient.statusEmergencyPatients
            };

            _context.EmergencyPatient.Add(emergencyPatientAux);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetEmergencyPatient),
                new { documentNumberEmergencyPatients = emergencyPatient.documentNumberEmergencyPatients },
                emergencyPatient_ToDTO(emergencyPatient));
        }

        private static EmergencyPatient emergencyPatient_ToDTO(EmergencyPatient emergencyPatient) =>
            new EmergencyPatient
            {
                idEmergencyPatients                 = emergencyPatient.idEmergencyPatients,
                documentNumberEmergencyPatients     = emergencyPatient.documentNumberEmergencyPatients,
                namesEmergencyPatients              = emergencyPatient.namesEmergencyPatients,
                lastNamesEmergencyPatients          = emergencyPatient.lastNamesEmergencyPatients,
                ageEmergencyPatients                = emergencyPatient.ageEmergencyPatients,
                addressEmergencyPatients            = emergencyPatient.addressEmergencyPatients,
                genderEmergencyPatients             = emergencyPatient.genderEmergencyPatients,
                heightEmergencyPatients             = emergencyPatient.heightEmergencyPatients,
                smokerEmergencyPatients             = emergencyPatient.smokerEmergencyPatients,
                dietEmergencyPatients               = emergencyPatient.dietEmergencyPatients,
                heightWeightRatioEmergencyPatients  = emergencyPatient.heightWeightRatioEmergencyPatients,
                weightEmergencyPatients             = emergencyPatient.weightEmergencyPatients,
                priorityEmergencyPatients           = emergencyPatient.priorityEmergencyPatients,
                riskEmergencyPatients               = emergencyPatient.riskEmergencyPatients,
                statusEmergencyPatients             = emergencyPatient.statusEmergencyPatients
            };

        private static double calculateheightWeightRatio(EmergencyPatient emergencyPatient)
        {
            return Convert.ToDouble(emergencyPatient.weightEmergencyPatients) / Convert.ToDouble(emergencyPatient.heightEmergencyPatients);
        }

        private static double calculatePriority(EmergencyPatient emergencyPatient)
        {
            double heightWeightRatio = emergencyPatient.heightWeightRatioEmergencyPatients,
                smokerEmergencyPatients = Convert.ToDouble(emergencyPatient.smokerEmergencyPatients),
                ageDouble = Convert.ToDouble(emergencyPatient.ageEmergencyPatients),
                priority;
            int age = emergencyPatient.ageEmergencyPatients;

            if (age >= 1 && age <= 15)
            {
                priority = heightWeightRatio;
                priority += age < 5 ? 3 : (age < 12 ? 2 : 1);
            }
            else if (age <= 40)
            {
                priority = emergencyPatient.smokerEmergencyPatients == 0 ? 2 : (smokerEmergencyPatients / 4 + 2);
            }
            else
            {
                priority =
                    emergencyPatient.dietEmergencyPatients != 0
                    && age <= 100
                    ? (ageDouble / 20 + 4) :
                    (ageDouble / 30 + 4);
            }
            return priority;
        }

        private static double calculateRisk(EmergencyPatient emergencyPatient)
        {
            double ageDouble = Convert.ToDouble(emergencyPatient.ageEmergencyPatients),
                priority = emergencyPatient.priorityEmergencyPatients;
            int age = emergencyPatient.ageEmergencyPatients;
            return age >= 1 && age <= 40 ? ((ageDouble * priority) / 100) : (((ageDouble * priority) / 100) + 5.3);
        }

         public bool exist(string documentNumber, string status)
        {
            var exists = _context.EmergencyPatient.Where(
                b => b.documentNumberEmergencyPatients.Equals(documentNumber) && b.statusEmergencyPatients.Equals(status)
                ).Select((c) => new
                {
                    idEmergencyPatients = c.idEmergencyPatients,
                    documentNumberEmergencyPatients = c.documentNumberEmergencyPatients,
                    namesEmergencyPatients = c.namesEmergencyPatients,
                    lastNamesEmergencyPatients = c.lastNamesEmergencyPatients,
                    ageEmergencyPatients = c.ageEmergencyPatients,
                    addressEmergencyPatients = c.addressEmergencyPatients,
                    genderEmergencyPatients = c.genderEmergencyPatients,
                    heightEmergencyPatients = c.heightEmergencyPatients,
                    smokerEmergencyPatients = c.smokerEmergencyPatients,
                    dietEmergencyPatients = c.dietEmergencyPatients,
                    heightWeightRatioEmergencyPatients = c.heightWeightRatioEmergencyPatients,
                    priorityEmergencyPatients = c.priorityEmergencyPatients,
                    riskEmergencyPatients = c.riskEmergencyPatients,
                    statusEmergencyPatients = c.statusEmergencyPatients
                }).ToList();
            return exists.Count > 0;
        }
    }

}

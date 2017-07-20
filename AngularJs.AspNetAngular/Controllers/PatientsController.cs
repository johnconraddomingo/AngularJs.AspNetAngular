using AngularJs.AspNetAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Http;

namespace AngularJs.AspNetAngular.Controllers
{

    public class PatientsController : ApiController
    {
        List<Patient> patients = new List<Patient>
       {
            new Patient { Id = 1, FirstName = "Oliver", LastName = "Queen", Age = 1 },
            new Patient { Id = 2, FirstName = "Damian", LastName = "Wayne", Age = 3 },
            new Patient { Id = 3, FirstName = "Diana", LastName = "Prince", Age = 5 }
       };

        [HttpGet]
        [Route("Patients")]
        public IHttpActionResult GetPatients()
        {
            return Ok(patients);
        }

        [HttpGet]
        [Route("Patient/{id}")]
        public IHttpActionResult GetPatient(int id)
        {
            var patientHere = patients.FirstOrDefault((p) => p.Id == id);
            if (patientHere == null)
            {
                return NotFound();
            }
            return Ok(patientHere);
        }


        [HttpGet]
        [Route("Patient/Search/{searchTerm}")]
        public IHttpActionResult SearchPatients(string searchTerm)
        {
            if (searchTerm == "undefined" || searchTerm == "")
                return GetPatients();

            var patientsFound = patients.Where(s => s.FirstName.Contains(searchTerm) || s.LastName.Contains(searchTerm)); 
            if (patientsFound == null)
            {
                return NotFound();
            }
            return Ok(patientsFound);
        }

    }
}
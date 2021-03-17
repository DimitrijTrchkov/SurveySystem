using midTerm.Data.Entities;
using midTerm.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Services.DTOs
{
    public class SurveyUserDTO
    {
        public SurveyUserDTO()
        {

        }
        public SurveyUserDTO(SurveyUser user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DoB = user.DoB;
            Gender = user.Gender;
            Country = user.Country;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}

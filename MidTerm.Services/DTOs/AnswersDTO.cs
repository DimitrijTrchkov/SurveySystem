using midTerm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Services.DTOs
{
    public class AnswersDTO
    {
        public AnswersDTO()
        {

        }    
        public AnswersDTO(Answers answer)
        {
            UserId = answer.UserId;
            OptionId = answer.OptionId;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OptionId { get; set; }
        public virtual OptionDTO Option { get; set; }
        public virtual SurveyUserDTO User { get; set; }
    }
}

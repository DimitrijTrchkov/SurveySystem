using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Services.DTOs
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? NumOrder { get; set; }

        public int QuestionId { get; set; }

        public virtual QuestionDTO Question { get; set; }
    }
}

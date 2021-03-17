using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Services.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OptionDTO> Options { get; set; }
    }
}

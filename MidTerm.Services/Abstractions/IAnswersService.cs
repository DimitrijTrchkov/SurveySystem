using MidTerm.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Abstractions
{
    public interface IAnswersService
    {
        Task<bool> CreateAnswers(AnswersDTO answers);
        Task<bool> DeleteAnswers(int Id);
        Task<AnswersDTO> EditAnswers(int Id, AnswersDTO user);
        Task<List<AnswersDTO>> GetAllAnswers();
        Task<AnswersDTO> GetAnswers(int id);
    }
}

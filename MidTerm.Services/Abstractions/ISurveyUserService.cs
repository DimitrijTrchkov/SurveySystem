using MidTerm.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Abstractions
{
    public interface ISurveyUserService
    {
        Task<bool> CreateSurveyUser(SurveyUserDTO user);
        Task<bool> DeleteSurveyUser(int userId);
        Task<SurveyUserDTO> EditSurveyUser(int userId, SurveyUserDTO user);
        Task<List<SurveyUserDTO>> GetAllSurveyUsers();
        Task<SurveyUserDTO> GetSurveyUser(int id);
    }
}

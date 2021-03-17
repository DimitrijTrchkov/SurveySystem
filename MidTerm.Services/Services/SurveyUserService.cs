
using Microsoft.EntityFrameworkCore;
using midTerm.Data;
using midTerm.Data.Entities;
using MidTerm.Services.Abstractions;
using MidTerm.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Services
{
    public class SurveyUserService : ISurveyUserService
    {
        private readonly SSContext _context;

        public SurveyUserService(SSContext context)
        {
            _context = context;
        }

        public async Task<List<SurveyUserDTO>> GetAllSurveyUsers()
        {
            var surveyUsers = await _context.SurveyUsers.Select(x => new SurveyUserDTO(x)).ToListAsync();
            return surveyUsers;
        }
        public async Task<SurveyUserDTO> GetSurveyUser(int id)
        {
            var surveyUser = await _context.SurveyUsers.Where(s => s.Id == id).FirstOrDefaultAsync();
            return new SurveyUserDTO(surveyUser);
        }

        public async Task<bool> CreateSurveyUser(SurveyUserDTO user)
        {
            var surveyUser = new SurveyUser
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                DoB = user.DoB,
                Gender = user.Gender,
                Country = user.Country
            };

            _context.SurveyUsers.Add(surveyUser);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<SurveyUserDTO> EditSurveyUser(int userId, SurveyUserDTO user)
        {
            var surveyUser = await _context.SurveyUsers.Where(x => x.Id == userId).FirstOrDefaultAsync();

            surveyUser.FirstName = user.FirstName;
            surveyUser.LastName = user.LastName;
            surveyUser.DoB = user.DoB;
            surveyUser.Country = user.Country;
            surveyUser.Gender = user.Gender;

            await _context.SaveChangesAsync();

            return new SurveyUserDTO(surveyUser);
        }

        public async Task<bool> DeleteSurveyUser(int userId)
        {
            var surveyUser = await _context.SurveyUsers.Where(x => x.Id == userId).FirstOrDefaultAsync();

            _context.SurveyUsers.Remove(surveyUser);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

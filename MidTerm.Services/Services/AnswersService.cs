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
    public class AnswersService : IAnswersService
    {
        private readonly SSContext _context;

        public AnswersService(SSContext context)
        {
            _context = context;
        }

        public async Task<List<AnswersDTO>> GetAllAnswers()
        {
            var answers = await _context.Answers.Select(x => new AnswersDTO(x)).ToListAsync();
            return answers;
        }
        public async Task<AnswersDTO> GetAnswers(int id)
        {
            var answers = await _context.Answers.Where(s => s.Id == id).FirstOrDefaultAsync();
            return new AnswersDTO(answers);
        }
        public async Task<bool> CreateAnswers(AnswersDTO answers)
        {
            var answer = new Answers
            {
                UserId = answers.UserId,
                OptionId = answers.OptionId
            };

            _context.Answers.Add(answer);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<AnswersDTO> EditAnswers(int Id, AnswersDTO user)
        {
            var answer = await _context.Answers.Where(x => x.Id == Id).FirstOrDefaultAsync();

            answer.UserId = user.UserId;
            answer.OptionId = user.OptionId;

            await _context.SaveChangesAsync();

            return new AnswersDTO(answer);
        }
        public async Task<bool> DeleteAnswers(int Id)
        {
            var answers = await _context.Answers.Where(x => x.Id == Id).FirstOrDefaultAsync();

            _context.Answers.Remove(answers);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

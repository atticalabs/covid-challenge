using AutoMapper;
using CovidChallenge.Data;
using CovidChallenge.DomainDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ChallengesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IList<GoalDto>> GetChallenges()
        {
            var result = await _context.Goals.Include(o => o.GoalActionsRules)
                                             .ThenInclude(o => o.Action)
                                             .ToListAsync();

            var resultDto = _mapper.Map<IList<GoalDto>>(result);

            return resultDto;
        }
    }
}

using AutoMapper;
using ChallengeAluraAdopet.API.Context;
using ChallengeAluraAdopet.API.DTO;
using ChallengeAluraAdopet.API.Models;

namespace ChallengeAluraAdopet.API.Repository;

public class TutorRepository : ITutorRepository
{
    private readonly MyContext _context;
    private readonly IMapper _mapper;


    public TutorRepository(MyContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<bool> CreateTutor(TutorDTO tutorDto)
    {
        var tutor = _mapper.Map<Tutor>(tutorDto);

        await _context.Tutor.AddAsync(tutor);
        var result = await _context.SaveChangesAsync();

        if(result > 0)
            return true;

        return false;
    }
}
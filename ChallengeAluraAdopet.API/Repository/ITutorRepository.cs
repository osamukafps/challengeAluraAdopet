using ChallengeAluraAdopet.API.DTO;

namespace ChallengeAluraAdopet.API.Repository;

public interface ITutorRepository
{
    Task<bool> CreateTutor(TutorDTO tutorDto);
}
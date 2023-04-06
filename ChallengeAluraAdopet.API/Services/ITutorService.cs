using ChallengeAluraAdopet.API.DTO;
using ChallengeAluraAdopet.API.Responses;

namespace ChallengeAluraAdopet.API.Services;

public interface ITutorService
{
    Task<InternalResponse> CreateTutor(TutorDTO tutorDto);
}
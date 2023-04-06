using ChallengeAluraAdopet.API.DTO;
using ChallengeAluraAdopet.API.Repository;
using ChallengeAluraAdopet.API.Responses;

namespace ChallengeAluraAdopet.API.Services;

public class TutorService : ITutorService
{
    private readonly ITutorRepository _tutorRepository;

    public TutorService(ITutorRepository repository)
    {
        _tutorRepository = repository;
    }
    
    public async Task<InternalResponse> CreateTutor(TutorDTO tutorDto)
    {
        try
        {
            var createTutorAttempt = await _tutorRepository.CreateTutor(tutorDto);

            if (!createTutorAttempt)
            {
                return new InternalResponse
                {
                    Code = 500,
                    Data = InternalResponse.SetData(tutorDto),
                    Message = $"Not Created",
                    Exception = null
                };
            }

            return new InternalResponse
            {
                Code = 201,
                Data = InternalResponse.SetData(tutorDto),
                Message = "Created",
                Exception = null
            };
        }
        catch (Exception exception)
        {
            return new InternalResponse
            {
                Code = 500,
                Data = InternalResponse.SetData(exception.StackTrace),
                Message = exception.Message,
                Exception = exception.InnerException
            };
        }
    }
}
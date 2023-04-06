using ChallengeAluraAdopet.API.DTO;
using ChallengeAluraAdopet.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAluraAdopet.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TutorController : ControllerBase
{
    private readonly ITutorService _tutorService;

    public TutorController(ITutorService service)
    {
        _tutorService = service;
    }

    [HttpPost]
    public async Task<IActionResult> PostTutor(TutorDTO tutorDto)
    {
        try
        {
            var createTutorAttempt = await _tutorService.CreateTutor(tutorDto);

            if (createTutorAttempt.Code != 201)
                return StatusCode(createTutorAttempt.Code, createTutorAttempt);

            return StatusCode(201, createTutorAttempt);
        }
        catch (Exception exception)
        {
            return StatusCode(500, exception);
        }
    }

}
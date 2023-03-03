
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Application.Activities;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
    private readonly IMediator _mediator;
        public ActivitiesController(IMediator mediator)
        {
      _mediator = mediator;

        }
        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
          return await _mediator.Send(new ListAllActivities.Query());
        }
        [HttpGet("{id}")] //api/activities/id
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
          return Ok();
    }
}
}
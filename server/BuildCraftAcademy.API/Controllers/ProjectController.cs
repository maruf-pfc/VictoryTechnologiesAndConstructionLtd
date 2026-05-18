using BuildCraftAcademy.API.Common;
using BuildCraftAcademy.API.DTOs.Project;
using BuildCraftAcademy.API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildCraftAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProjects([FromQuery] bool publishedOnly = false)
        {
            var response = await _projectService.GetAllProjectsAsync(publishedOnly);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectById(Guid id)
        {
            var response = await _projectService.GetProjectByIdAsync(id);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] CreateProjectDto request)
        {
            var response = await _projectService.CreateProjectAsync(request);
            if (!response.Success)
                return BadRequest(response);

            return CreatedAtAction(nameof(GetProjectById), new { id = response.Data?.Id }, response);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(Guid id, [FromBody] UpdateProjectDto request)
        {
            var response = await _projectService.UpdateProjectAsync(id, request);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            var response = await _projectService.DeleteProjectAsync(id);
            if (!response.Success)
                return NotFound(response);

            return Ok(response);
        }
    }
}

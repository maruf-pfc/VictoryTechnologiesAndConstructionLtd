using BuildCraftAcademy.API.Common;
using BuildCraftAcademy.API.DTOs.Project;

namespace BuildCraftAcademy.API.Interfaces
{
    public interface IProjectService
    {
        Task<ApiResponse<IEnumerable<ProjectResponseDto>>> GetAllProjectsAsync(bool publishedOnly = false);
        Task<ApiResponse<ProjectResponseDto>> GetProjectByIdAsync(Guid id);
        Task<ApiResponse<ProjectResponseDto>> CreateProjectAsync(CreateProjectDto request);
        Task<ApiResponse<ProjectResponseDto>> UpdateProjectAsync(Guid id, UpdateProjectDto request);
        Task<ApiResponse<bool>> DeleteProjectAsync(Guid id);
    }
}

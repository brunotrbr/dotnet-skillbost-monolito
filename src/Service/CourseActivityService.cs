using src.Domain.Dtos;
using src.Domain.Models;
using src.Repository.Interface;
using src.Service.Interface;

namespace src.Service;

public class CourseActivityService(ICourseActivityRepository courseActivityRepository, ICourseService courseService) : ICourseActivityService
{
    private readonly ICourseActivityRepository _courseActivityRepository = courseActivityRepository;
    private readonly ICourseService _courseService = courseService;

    public async Task<CourseActivity> Create(long courseId, CourseActivityDto courseActivityDto)
    {
        var course = await _courseService.Get(courseId) ?? throw new KeyNotFoundException($"Course with id {courseId} not found.");
        var courseActivity = new CourseActivity(courseActivityDto)
        {
            Course = course
        };
        return await _courseActivityRepository.Create(courseId, courseActivity);
    }

    public async Task Delete(long activityId)
    {
        await _courseActivityRepository.Delete(activityId);
    }

    public async Task<CourseActivity> Get(long activityId)
    {
        return await GetById(activityId) ?? throw new KeyNotFoundException($"CourseActivity with id {activityId} not found.");
    }

    public async Task<List<CourseActivity>> ListByCourseId(long courseId)
    {
        return await _courseActivityRepository.GetAllByCourseId(courseId);
    }

    public async Task<CourseActivity> Update(long activityId, CourseActivityDto courseActivityDto)
    {
        var existingCourseActivity = await GetById(activityId) ?? throw new KeyNotFoundException($"CourseActivity with id {activityId} not found.");
        existingCourseActivity.UpdateFromDto(courseActivityDto);
        return await _courseActivityRepository.Update(existingCourseActivity);
    }

    private async Task<CourseActivity> GetById(long activityId)
    {
        return await _courseActivityRepository.Get(activityId);
    }
}

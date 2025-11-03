using src.Domain.Dtos;
using src.Domain.Models;

namespace src.Service.Interface;

public interface ICourseActivityService
{
    public abstract Task<CourseActivity> Create(long courseId, CourseActivityDto courseActivityDto);

    public abstract Task<CourseActivity> Get(long activityId);

    public abstract Task<List<CourseActivity>> ListByCourseId(long courseId);

    public abstract Task<CourseActivity> Update(long activityId, CourseActivityDto courseActivityDto);

    public abstract Task Delete(long activityId);
}

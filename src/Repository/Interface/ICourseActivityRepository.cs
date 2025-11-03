using src.Domain.Models;

namespace src.Repository.Interface;

public interface ICourseActivityRepository
{
    public abstract Task<CourseActivity> Create(long courseId, CourseActivity courseActivity);

    public abstract Task<CourseActivity> Get(long activityId);

    public abstract Task<List<CourseActivity>> GetAllByCourseId(long courseId);

    public abstract Task<CourseActivity> Update(CourseActivity courseActivity);

    public abstract Task Delete(long activityId);
}

using System;
using src.Domain.Dtos;
using src.Domain.Models;
using src.Repository.Interface;

namespace src.Repository;

public class CourseActivityRepository : ICourseActivityRepository
{
    public Task<CourseActivity> Create(long courseId, CourseActivity courseActivity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long activityId)
    {
        throw new NotImplementedException();
    }

    public Task<CourseActivity> Get(long activityId)
    {
        throw new NotImplementedException();
    }

    public Task<List<CourseActivity>> GetAllByCourseId(long courseId)
    {
        throw new NotImplementedException();
    }

    public Task<CourseActivity> Update(CourseActivity courseActivity)
    {
        throw new NotImplementedException();
    }
}

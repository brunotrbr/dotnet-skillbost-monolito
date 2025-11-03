using System;
using src.Domain.Dtos;
using src.Domain.Models;
using src.Repository.Interface;

namespace src.Repository;

public class CourseRepository : ICourseRepository
{
    public Task<Course> Create(Course course)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Course> Get(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Course>> List()
    {
        throw new NotImplementedException();
    }

    public Task<Course> Update(Course course)
    {
        throw new NotImplementedException();
    }
}

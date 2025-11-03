using System;
using src.Domain.Dtos;
using src.Domain.Models;

namespace src.Repository.Interface;

public interface ICourseRepository
{
    public abstract Task<Course> Create(Course course);

    public abstract Task<Course> Get(long id);

    public abstract Task<List<Course>> List();

    public abstract Task<Course> Update(Course course);

    public abstract Task Delete(long id);
}

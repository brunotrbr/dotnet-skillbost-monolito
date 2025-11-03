using src.Domain.Dtos;
using src.Domain.Models;

namespace src.Service.Interface;

public interface ICourseService
{
    public abstract Task<Course> Create(CourseDto courseDto);

    public abstract Task<Course> Get(long id);

    public abstract Task<List<Course>> List();

    public abstract Task<Course> Update(long id, CourseDto courseDto);

    public abstract Task Delete(long id);
}

using src.Domain.Dtos;
using src.Domain.Models;
using src.Repository.Interface;
using src.Service.Interface;

namespace src.Service;

public class CourseService(ICourseRepository courseRepository) : ICourseService
{
    private readonly ICourseRepository _courseRepository = courseRepository;

    
    public async Task<Course> Create(CourseDto courseDto)
    {
        var course = new Course(courseDto);
        return await _courseRepository.Create(course);
    }

    public async Task Delete(long id)
    {
        await _courseRepository.Delete(id);
    }

    public async Task<Course> Get(long id)
    {
        return await GetById(id);
    }

    public async Task<List<Course>> List()
    {
        return await _courseRepository.List();
    }

    public async Task<Course> Update(long id, CourseDto courseDto)
    {
        var existingCourse = await GetById(id);
        existingCourse.Update(courseDto);
        return await _courseRepository.Update(existingCourse);
    }

    private async Task<Course> GetById(long id)
    {
        return await _courseRepository.Get(id) ?? throw new KeyNotFoundException($"Course with id {id} not found.");
    }

    
}

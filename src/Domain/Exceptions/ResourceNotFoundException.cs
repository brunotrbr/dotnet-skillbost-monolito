using System;

namespace src.Domain.Exceptions;

public class ResourceNotFoundException : Exception
{
    public ResourceNotFoundException(long resourceId) : base($"Resource not found with id {resourceId}")
    {

    }
    
    public ResourceNotFoundException(string message, Exception exception) : base(message, exception)
    {

    }
}

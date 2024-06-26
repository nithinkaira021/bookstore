﻿namespace Core.Exceptions;

[Serializable]
public abstract class ResourceNotFoundException : Exception
{
    protected const string DEFAULT_ERROR_MESSAGE = "{0} not found.";

    public readonly string Resource;

    public ResourceNotFoundException(string resource = "Resource") 
        : base(string.Format(DEFAULT_ERROR_MESSAGE, resource))
    {
        Resource = resource;
    }
}

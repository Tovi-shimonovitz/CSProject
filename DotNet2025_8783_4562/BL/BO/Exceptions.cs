using System;

namespace BL.BO;

[Serializable]
public class BlObjectNotFoundException : Exception
{
    public BlObjectNotFoundException(string? message) : base(message) { }
    public BlObjectNotFoundException(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BlObjectExistException : Exception
{
    public BlObjectExistException(string? message) : base(message) { }
    public BlObjectExistException(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BlInvalidInputException : Exception
{
    public BlInvalidInputException(string? message) : base(message) { }
    public BlInvalidInputException(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BlIneligibleException : Exception
{
    public BlIneligibleException(string? message) : base(message) { }
    public BlIneligibleException(string message, Exception innerException)
                : base(message, innerException) { }
}

[Serializable]
public class BlNullPropertyException : Exception
{
    public BlNullPropertyException(string? message) : base(message) { }
    public BlNullPropertyException(string message, Exception innerException)
                : base(message, innerException) { }
}
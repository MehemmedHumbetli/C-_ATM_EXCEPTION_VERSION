using System;


public class IncorrectAmountException : Exception
{
    public string Message { get; set; }
    public IncorrectAmountException(string message)
    {
        this.Message = message;
    }
}

public class IncorrectPinException : Exception
{
    public string Message { get; set; }
    public IncorrectPinException(string message)
    {
        this.Message = message;
    }
}

public class InccorectPinLenException : Exception
{
    public string Message { get; set; }
    public InccorectPinLenException(string message)
    {
        Message = message;
    }
}

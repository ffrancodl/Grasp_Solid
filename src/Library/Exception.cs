using System;
using System.Collections;
using System.Collections.Generic;

public class EmptyException : Exception
{
    
    public EmptyException(string mensaje) : base (mensaje)
    {
        
    }
}
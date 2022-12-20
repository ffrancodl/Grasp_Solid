using System;
using System.Collections;
using System.Collections.Generic;

public class EmptyException : Exception
{
    /// <summary>
    /// excepcion en caso de que la lista esté vacia
    /// </summary>
    public EmptyException (string mensaje) : base (mensaje)
    {
        
    }
}
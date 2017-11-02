using System;

namespace Mic.FixerSharp.Framework
{
    public class FixerException : Exception
    {
        public FixerException(int errorCode)
        {
            ErrorCode = errorCode;
        }

        public int ErrorCode { get; private set; } 
    }
}

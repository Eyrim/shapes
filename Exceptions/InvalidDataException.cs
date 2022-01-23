namespace Shapes.Exceptions
{
    public class InvalidDataException : System.Exception
    {
        public InvalidDataException() 
        { 

        }
        
        public InvalidDataException(string message) : base(message) 
        { 

        }

        public InvalidDataException(string message, System.Exception inner) : base(message, inner) 
        {

        }
    }
}
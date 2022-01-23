namespace Shapes.Exceptions
{
    public class InvalidShapeException : System.Exception
    {
        public InvalidShapeException() 
        { 

        }
        
        public InvalidShapeException(string message) : base(message) 
        { 

        }

        public InvalidShapeException(string message, System.Exception inner) : base(message, inner) 
        {

        }
    }
}
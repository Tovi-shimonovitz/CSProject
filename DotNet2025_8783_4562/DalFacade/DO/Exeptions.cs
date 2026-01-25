

namespace DO
{
    public class ObjectNotFoundExeption : Exception
    {
        
        public ObjectNotFoundExeption(string message, Exception innerExeption) : base(message, innerExeption) 
        { 
     
        }
        public ObjectNotFoundExeption(string message) : base(message)
        {

        }

    }

    public class ObjectExistExeption : Exception
    {

        public ObjectExistExeption(string message, Exception innerExeption) : base(message, innerExeption)
        {

        }
        public ObjectExistExeption(string message) : base(message)
        {

        }
    }
}

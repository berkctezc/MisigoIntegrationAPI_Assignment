namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //constructor iki parametre aldığında burası çalışacak
        public Result(bool success, string message) : this(success)
        {
            //setter yok fakat constructorda set edilip sonradan set edilmemesi için
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
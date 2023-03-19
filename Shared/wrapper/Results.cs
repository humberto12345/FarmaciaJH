
namespace FarmaciaJH.Shared.Wrapper;

public class Result
{
    public Result()
    {

    }
    public Result(bool succeeded, List<string>? message = default!)
    {
        Succeeded = Succeeded;
        Message = Message;
    }

    public bool Succeeded { get; set; }
    public List<string>? Message { get; set; }
    public static Result Fail()
    {

        return new Result(false);
    }
    public static Result Fail(string Message)
    {

        return new Result(false, new List<string>() { Message });
    }
    public static Result Fail(List<string> message)
    {

        return new Result(false, message);
    }
    public static Result Sucess(string message)
    {

        return new Result(false, new List<string>() { message });
    }

    public static Result Sucess(List<string> message)
    {

        return new Result(true, message);
    }
}

public class Result<T> : Result
{
    public T Data { get; set; } = default!;
    public new static Result<T> Fail()
    {
        return new Result<T>() { Succeeded = false, Message = new List<string>() { "X" }};

    }
     public new static Result<T> Fail(String message)
    {
        return new Result<T>() { Succeeded = false, Message = new List<string>() {message}};

    }
     public new static Result<T> Fail(List<String> messages)
    {
        return new Result<T>() { Succeeded = false, Message = messages};

    }
     public new static Result<T> Success(T Data)
    {
        return new Result<T>() { Succeeded = true,
         Message = new List<string>() {"OK"},
         Data = Data
         };

    }



}


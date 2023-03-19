
namespace FarmaciaJH.Shared.Wrapper;

public class ResultList<T>: Result
{
    public IEnumerable<T> Items {get;set;}= default!;

    public static ResultList<T> Faile(){
        return new ResultList<T>(){Succeeded = false, Message = new List<String>(){"X"}};
    }

 public static ResultList<T> Success(IEnumerable<T>items)
 {
        return new ResultList<T>(){
            Succeeded = true,
             Message = new List<String>(){"OK"},
             Items = items
             };
    }

}


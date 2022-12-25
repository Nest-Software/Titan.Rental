namespace Core.Models;

public class ApiResponse<T>
{
       

    public ApiResponse(string code, T data)
    {
        Code = code;
        Data = data;
    }

    public ApiResponse(string code, string message, T data)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    public ApiResponse(string code, string status, string message, T data)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    public ApiResponse()
    {
    }

    public string Message { get; set; }
    public string Code { get; set; }
    public T Data { get; set; }
    public bool IsSuccessful => Code.Contains("200") || Code.Contains("201") || Code.Contains("2000");
}

public class BaseApiResponse<T>
{
    public int? Code { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public bool IsSuccessful => Code == 200 || Code == 201 || Code == 2000;
}
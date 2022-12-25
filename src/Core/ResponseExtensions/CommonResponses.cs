using System.Net;
using Core.Models;

namespace Core.ResponseExtensions;

public static class CommonResponses
{
    private const string InternalServerErrorResponseMessage = "Something bad happened, try again later";
    private const string FailedDependencyErrorResponseMessage = "An error occured, try again later";
    private const string DefaultOkResponseMessage = "Success";
    private const string DefaultNotFoundResponseMessage = "Resource not found";
    private const string DefaultCreatedResponseMessage = "Created successfully";
    private const string DefaultBadRequestResponseMessage = "Bad request";
    private const string DefaultConflictResponseMessage = "Resource already created";
    private const string DefaultUnauthorizedResponseMessage = "Unauthorized";
    
    public static class ErrorResponse
        {
            public static ApiResponse<T> InternalServerErrorResponse<T>() =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.InternalServerError}",
                    Message = InternalServerErrorResponseMessage
                };

            public static ApiResponse<T> FailedDependencyErrorResponse<T>() =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.FailedDependency}",
                    Message = FailedDependencyErrorResponseMessage
                };

            public static ApiResponse<T> NotFoundResponse<T>(string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.NotFound}",
                    Message = message ?? DefaultNotFoundResponseMessage
                };

            public static ApiResponse<T> BadRequestResponse<T>(string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.BadRequest}",
                    Message = message ?? DefaultBadRequestResponseMessage
                };

            public static ApiResponse<T> ConflictResponse<T>(string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.Conflict}",
                    Message = message ?? DefaultConflictResponseMessage
                };

            public static ApiResponse<T> UnAuthorizedResponse<T>(string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.Unauthorized}",
                    Message = message ?? DefaultUnauthorizedResponseMessage
                };
        }
    public static class SuccessResponse
        {
            public static ApiResponse<T> OkResponse<T>(T data, string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.OK}",
                    Message = message ?? DefaultOkResponseMessage,
                    Data = data
                };

            public static ApiResponse<T> CreatedResponse<T>(T data, string message = null) =>
                new ApiResponse<T>
                {
                    Code = $"{(int)HttpStatusCode.Created}",
                    Message = message ?? DefaultCreatedResponseMessage,
                    Data = data
                };
        }
}
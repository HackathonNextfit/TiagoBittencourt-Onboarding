using BackHackathon.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BackHackathon.Api.Filters
{
    public class ApiBaseResponseFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
            {
                var valueType = objectResult.Value?.GetType();
                if (valueType != null && IsSubclassOfRawGeneric(typeof(ApiBaseResponse<>), valueType))
                {
                    context.Result = objectResult;
                }
                else
                {
                    var apiBaseResponse = new ApiBaseResponse<object>
                    {
                        Success = objectResult.StatusCode >= 200 && objectResult.StatusCode < 300,
                        Content = objectResult.StatusCode >= 200 && objectResult.StatusCode < 300 ? objectResult.Value : null,
                        Message = objectResult.StatusCode >= 400 ? "Erro geral" : null
                    };

                    context.Result = new ObjectResult(apiBaseResponse)
                    {
                        StatusCode = objectResult.StatusCode
                    };
                }

                context.ExceptionHandled = true;
            }
        }

        private bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }
    }
}

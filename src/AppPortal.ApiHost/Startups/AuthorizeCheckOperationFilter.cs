using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace AppPortal.ApiHost.Startups
{
    public class AuthorizeCheckOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            // Policy names map to scopes
            var requiredScopes = context.MethodInfo.DeclaringType.GetCustomAttributes(true)
              .Union(context.MethodInfo.GetCustomAttributes(true))
              .OfType<AuthorizeAttribute>()
              .Select(attr => attr.Policy);

            if (requiredScopes.Any())
            {
                operation.Responses.Add("400", new Response { Description = "Bad Request" });
                operation.Responses.Add("401", new Response { Description = "Unauthorized" });
                operation.Responses.Add("403", new Response { Description = "Forbidden" });
                operation.Responses.Add("502", new Response { Description = "502 Bad Gateway" });

                operation.Security = new List<IDictionary<string, IEnumerable<string>>>
                {
                    new Dictionary<string, IEnumerable<string>>
                    {
                        { "Bearer", requiredScopes }
                    }
                };
            }
        }
    }
}

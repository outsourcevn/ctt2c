using System;
using System.Collections.Generic;

namespace AppPortal.Core.Responses
{
    public interface IResponse
    {
        String Message { get; set; }
        Boolean DidError { get; set; }
        List<string> Errors { get; set; }
    }
}

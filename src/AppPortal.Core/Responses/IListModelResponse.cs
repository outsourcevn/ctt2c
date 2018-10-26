using System;
using System.Collections.Generic;

namespace AppPortal.Core.Responses
{
    public interface IListModelResponse<TModel> : IResponse
    {
        IPaging Page { get; set; }
        IEnumerable<TModel> Datas { get; set; }
    }
}

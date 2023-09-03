using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCrafter.Action.Response.Base
{
    /// <summary>
    /// Represents an interface for action response data of type <typeparamref name="TResponseData"/>.
    /// </summary>
    /// <typeparam name="TResponseData">The type of the response data.</typeparam>
    public interface IActionResponseData<TResponseData>
        where TResponseData : class, IResponseData
    {
        /// <summary>
        /// Gets the response data.
        /// </summary>
        TResponseData ResponseData { get; protected set; }
    }
}
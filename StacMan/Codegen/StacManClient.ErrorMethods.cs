// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackExchange.StacMan
{
    public partial class StacManClient : IErrorMethods
    {
        /// <summary>
        /// Stack Exchange API Errors methods
        /// </summary>
        public IErrorMethods Errors
        {
            get { return this; }
        }

        Task<StacManResponse<Error>> IErrorMethods.GetAll(string filter = null, int? page = null, int? pagesize = null)
        {
            ValidatePaging(page, pagesize);

            var ub = new ApiUrlBuilder("/errors", useHttps: false);

            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);

            return CreateApiTask<Error>(ub, "/errors");
        }

        Task<StacManResponse<Error>> IErrorMethods.Simulate(int id, string filter = null)
        {

            var ub = new ApiUrlBuilder(String.Format("/errors/{0}", id), useHttps: false);

            ub.AddParameter("filter", filter);

            return CreateApiTask<Error>(ub, "/errors/{id}");
        }
    }

    public interface IErrorMethods
    {
        /// <summary>
        /// Get descriptions of all the errors that the API could return. (API Method: "/errors")
        /// </summary>
        Task<StacManResponse<Error>> GetAll(string filter = null, int? page = null, int? pagesize = null);

        /// <summary>
        /// Simulate an API error for testing purposes. (API Method: "/errors/{id}")
        /// </summary>
        Task<StacManResponse<Error>> Simulate(int id, string filter = null);

    }
}

#pragma warning restore 1591

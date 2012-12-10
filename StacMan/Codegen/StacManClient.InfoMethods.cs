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
    public partial class StacManClient : IInfoMethods
    {
        /// <summary>
        /// Stack Exchange API Info methods
        /// </summary>
        public IInfoMethods Info
        {
            get { return this; }
        }

        Task<StacManResponse<Info>> IInfoMethods.Get(string site, string filter = null)
        {
            ValidateString(site, "site");

            var ub = new ApiUrlBuilder("/info", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);

            return CreateApiTask<Info>(ub, "/info");
        }
    }

    public interface IInfoMethods
    {
        /// <summary>
        /// Get information about the entire site. (API Method: "/info")
        /// </summary>
        Task<StacManResponse<Info>> Get(string site, string filter = null);

    }
}

#pragma warning restore 1591

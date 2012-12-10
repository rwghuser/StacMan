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
    public partial class StacManClient : ISearchMethods
    {
        /// <summary>
        /// Stack Exchange API Search methods
        /// </summary>
        public ISearchMethods Search
        {
            get { return this; }
        }

        Task<StacManResponse<Question>> ISearchMethods.GetMatches(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.SearchSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null, string nottagged = null, string inttitle = null)
        {
            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/search", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);
            ub.AddParameter("nottagged", nottagged);
            ub.AddParameter("inttitle", inttitle);

            return CreateApiTask<Question>(ub, "/search");
        }

        Task<StacManResponse<Question>> ISearchMethods.GetSimilar(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.SearchSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null, string nottagged = null, string inttitle = null)
        {
            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/similar", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);
            ub.AddParameter("tagged", tagged);
            ub.AddParameter("nottagged", nottagged);
            ub.AddParameter("inttitle", inttitle);

            return CreateApiTask<Question>(ub, "/similar");
        }
    }

    public interface ISearchMethods
    {
        /// <summary>
        /// Search the site for questions meeting certain criteria. (API Method: "/search")
        /// </summary>
        Task<StacManResponse<Question>> GetMatches(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.SearchSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null, string nottagged = null, string inttitle = null);

        /// <summary>
        /// Search the site based on similarity to a title. (API Method: "/similar")
        /// </summary>
        Task<StacManResponse<Question>> GetSimilar(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Questions.SearchSort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null, string tagged = null, string nottagged = null, string inttitle = null);

    }
}

#pragma warning restore 1591

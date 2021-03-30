using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;

namespace OData_Demo
{
    public class CustomEnableQuery : EnableQueryAttribute
    {
        public override IQueryable ApplyQuery(IQueryable queryable, ODataQueryOptions queryOptions)
        {
            if (queryOptions.Top != null)
            {
                return queryOptions.ApplyTo(queryable, new ODataQuerySettings { PageSize = queryOptions.Top.Value });
            }
            return base.ApplyQuery(queryable, queryOptions);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class SalesAndMarketingController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public FundRequest addFundRequest(int ammount, String reason)
        {
            FundRequest fundRequest = new FundRequest()
            {
                FundRequestAmmount = ammount,
                FundRequestReason = reason,
                FundRequestFrom = "Marketing",
            };
            db.FundRequests.Add(fundRequest);
            db.SaveChanges();

            return fundRequest;
        }

        public object ViewAllMarketingRequest()
        {
            var data = (from fundrequest in db.FundRequests
                        where fundrequest.FundRequestFrom.Equals("Marketing")
                        select new
                        {
                           id = fundrequest.FundRequestId,
                           ammount = fundrequest.FundRequestAmmount,
                           reason = fundrequest.FundRequestReason,
                           status = fundrequest.FundRequestStatus,

                        }).ToList();
            return data;
        }
    }
}

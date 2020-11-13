using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Controller
{
    class AccountingAndFinanceController
    {
        DatabaseHotelEntities db = new DatabaseHotelEntities();

        public FundRequest ApprovalRequest(int id)
        {
            FundRequest request = db.FundRequests.Find(id);
            request.FundRequestStatus = 1;

            db.SaveChanges();

            return request;
        }

        public FundRequest RejectApproval(int id)
        {
            FundRequest request = db.FundRequests.Find(id);
            request.FundRequestStatus = 2;

            db.SaveChanges();

            return request;
        }

        public object ViewAllFundRequest()
        {
            var data = (from fundrequest in db.FundRequests
                        where fundrequest.FundRequestStatus == 0
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

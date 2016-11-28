using System;

namespace AvantPoc.Models
{
    public class PolicyDetailsInfo
    {
       
            public string PolicyReferenceNumber { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string AlliancePolicyNumber { get; set; }
            public string Status { get; set; }
            public string PremiumCost { get; set; }
            public string State { get; set; }
            public string PolicyCode { get; set; }
            public string CreatedBy { get; set; }
            public string ApprovedBy { get; set; }
            public string PaymentScheduleInfo { get; set; }
            public string Notes { get; set; }

            public string BasePremiumInfo { get; set; }
            public string GrossWrittenPremium { get; set; }
            public string TotalInvoiced { get; set; }
            public string CommissionIncome { get; set; }
            public string GST { get; set; }
            public string NetDueToPartner { get; set; }

            public TaxAndStampDuty taxinfo { get; set; }


            public PolicyDetailsInfo CreateMockData()
            {
                PolicyDetailsInfo policyDetailsInfo = this;

                policyDetailsInfo.PolicyReferenceNumber = "BPK123456789";
                policyDetailsInfo.StartDate = DateTime.Now;
                policyDetailsInfo.EndDate = DateTime.Now;
                policyDetailsInfo.AlliancePolicyNumber = "ABK2468958-02";
                policyDetailsInfo.Status = "WORKING";

                policyDetailsInfo.PremiumCost = "$1390.00";
                policyDetailsInfo.State = "NSW";
                policyDetailsInfo.PolicyCode = "BPK";
                policyDetailsInfo.CreatedBy = "Dheeraj Gupta";
                policyDetailsInfo.ApprovedBy = "Sam";

                policyDetailsInfo.BasePremiumInfo = "$1000.00";
                policyDetailsInfo.GrossWrittenPremium = "$1000.00";
                policyDetailsInfo.TotalInvoiced = "$1390.00";
                policyDetailsInfo.CommissionIncome = "$225.00";
                policyDetailsInfo.GST = "$22.50";
                policyDetailsInfo.NetDueToPartner = "$1142.50";

                TaxAndStampDuty taxinfo = new TaxAndStampDuty { GST = "$100.00", StampDuty = "$55:00", FSL = "$235:00", Commission = "$0.00" };

                policyDetailsInfo.taxinfo = taxinfo;

                return policyDetailsInfo;
            }


    }
}

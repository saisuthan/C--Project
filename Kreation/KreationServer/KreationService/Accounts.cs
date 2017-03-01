using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KreationService
{
    [DataContract]
    public class Accounts
    {
        [DataMember]
        private String BranchId;

        public String branchId
        {
            get { return BranchId; }
            set { BranchId = value; }
        }

        [DataMember]
        private String TrNo;

        public String trNo
        {
            get { return TrNo; }
            set { TrNo = value; }
        }

        [DataMember]
        private String Description;

        public String description
        {
            get { return Description; }
            set { Description = value; }
        }

        [DataMember]
        private String Debit;

        public String debit
        {
            get { return Debit; }
            set { Debit = value; }
        }

        [DataMember]
        private String Credit;

        public String credit
        {
            get { return Credit; }
            set { Credit = value; }
        }
    }
}

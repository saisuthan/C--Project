using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KreationService
{
    
    [DataContract]
    public class Log
    {

        [DataMember]
        private String Username;

        public String username
        {
            get { return Username; }
            set { Username = value; }
        }

        [DataMember]
        private String Password;

        public String password
        {
            get { return Password; }
            set { Password = value; }
        }

        [DataMember]
        private String type;

        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        [DataMember]
        private String branch;

        public String Branch
        {
            get { return branch; }
            set { branch = value; }
        }
    }
}

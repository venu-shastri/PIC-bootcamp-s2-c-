using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //Child,Derived ,Specialized,Variation
   internal class StudentIdCard :IdCard
    {
        #region DataMembers

        private string studentId;

        #endregion

        #region Constructor

        internal StudentIdCard(string id, string name, string bloodgroup):base(name,bloodgroup)
        {
            this.studentId = id;
        }
        #endregion
        #region Properties

        internal string StudentId
        {
            get { return this.studentId; }
        }
        #endregion
    }
}

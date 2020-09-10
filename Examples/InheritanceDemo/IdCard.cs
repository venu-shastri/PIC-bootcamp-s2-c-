using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //Parent,Base , Generalize , Common
    internal class IdCard
    {
        #region Data Memebers
        private string name;
        private string bloodGroup;
        #endregion

        #region Constructor

        internal IdCard(string name,string bloodGroup)
        {
            this.name = name;
            this.bloodGroup = bloodGroup;
        }
        #endregion
        #region Properties

        internal string Name
        {
            get { return this.name; }
        }
        internal string BloodGroup
        {
            get { return this.bloodGroup; }
        }
        #endregion
    }
}

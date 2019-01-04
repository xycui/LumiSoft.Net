using System;
using System.Collections.Generic;
using System.Text;

namespace LumiSoft.Net
{
    /// <summary>
    /// Implements TEL URI. Defined in RFC 2806.
    /// </summary>
    public class TEL_Uri : AbsoluteUri
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        internal TEL_Uri()
        {
        }


        #region Properties implementation
        /// <summary>
        /// 
        /// </summary>
        public bool IsGlobal
        {
            get{ return false; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNmber
        {
            get{ return ""; }
        }


        #endregion

    }
}

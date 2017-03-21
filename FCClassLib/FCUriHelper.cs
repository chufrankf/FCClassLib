using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace FCClassLib
{
    public class FCUriHelper : UriBuilder
    {
        public FCUriHelper(string uri) : base(uri){ }

        #region Methods
        public void SetParameters(Dictionary<string,string> prmts)
        {
            if(prmts != null)
            {
                this.Query = prmts.ToQueryString();
            }
        }
        #endregion
    }
}

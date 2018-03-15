using Sitecore.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace Sitecore.Support.Shell.Applications.ContentManager.Dialogs.LayoutDetails
{
    public class LayoutDetailsForm : Sitecore.Shell.Applications.ContentManager.Dialogs.LayoutDetails.LayoutDetailsForm
    {
        public override string Layout
        {
            get
            {
                return base.Layout;
            }

            set
            {
                base.Layout = value;
                if (!string.IsNullOrEmpty(this.LayoutDelta))
                {
                    XmlDocument xmlDocument = XmlUtil.LoadXml(this.LayoutDelta);
                    if (!xmlDocument.Schemas.Contains("xmlns:p=\"p\""))
                    {
                        this.FinalLayout = this.LayoutDelta;
                    }
                }
            }
        }
    }
}
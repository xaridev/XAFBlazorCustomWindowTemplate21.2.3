using DevExpress.Persistent.Base;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XAFBlazorCustomWindowTemplate21._2._3.Module.Blazor.Controllers;

namespace XAFBlazorCustomWindowTemplate21._2._3.Module.Blazor
{
    public class ValueManagers
    {
       
        private const string controllerReference = "Reference";

        public static DotNetObjectReference<OpenDetailViewController> ControllerReference
        {
            get
            {
                var valueManager = ValueManager.GetValueManager<DotNetObjectReference<OpenDetailViewController>>(controllerReference);
                return valueManager.Value;
            }
            set
            {
                var valueManager = ValueManager.GetValueManager<DotNetObjectReference<OpenDetailViewController>>(controllerReference);
                if (valueManager.CanManageValue)
                    valueManager.Value = value;
            }
        }
    }
}

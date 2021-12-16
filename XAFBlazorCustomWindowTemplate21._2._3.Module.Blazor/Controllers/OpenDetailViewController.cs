using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XAFBlazorCustomWindowTemplate21._2._3.Module.BusinessObjects;

namespace XAFBlazorCustomWindowTemplate21._2._3.Module.Blazor.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class OpenDetailViewController : ViewController<ListView>
    {
        private IJSRuntime JSRuntime { get; set; }
        private DotNetObjectReference<OpenDetailViewController> controllerReference;
        BlazorApplication application { get; set; }
        Frame MyFrame { get; set; }
        public OpenDetailViewController()
        {
            InitializeComponent();
            controllerReference = DotNetObjectReference.Create(this);
            ValueManagers.ControllerReference = controllerReference;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            application = (BlazorApplication)Application;
            this.MyFrame = Frame;
            JSRuntime = application.ServiceProvider.GetRequiredService<IJSRuntime>();
            //_ = JSRuntime.InvokeVoidAsync("customScript.registerController", controllerReference).Preserve();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        [JSInvokable]
        public void ShowDetailView(string oidString)
        {
            //if (!Guid.TryParse(oidString, out var oid))
            //{
            //    return;
            //}
            //var objectSpace = application.CreateObjectSpace(typeof(Contact));
            //var item = objectSpace.FirstOrDefault<Contact>(contact => contact.Oid == oid);
            //if (item is not null)
            //{
            //    var detailView = application.CreateDetailView(objectSpace, item);
            //    MyFrame.SetView(detailView);
            //}
            MessageOptions options = new MessageOptions();

            options.Duration = 3000;
            options.Web.CanCloseOnClick = true;
            options.Web.CssClass = "w-100";
            options.Web.CanCloseOnOutsideClick = true;
            options.Message = "Hello Xafers.";
            options.Type = InformationType.Success;
            options.Web.Position = InformationPosition.Top;
            options.Web.OkButtonText = "";
            application.ShowViewStrategy.ShowMessage(options);
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            
        }
    }
}

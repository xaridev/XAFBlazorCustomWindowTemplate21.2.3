using Microsoft.AspNetCore.Components;

namespace XAFBlazorCustomWindowTemplate21._2._3.Blazor.Server.Templates
{
    public class CustomWindowTemplate : DevExpress.ExpressApp.Blazor.Templates.ApplicationWindowTemplate
    {
        protected override RenderFragment CreateComponent()
        {
            return CustomWindowTemplateComponent.Create(this);
        }
    }
}

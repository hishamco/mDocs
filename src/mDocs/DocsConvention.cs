using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace mDocs
{
    public class DocsConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerName == "Documentation")
            {
                controller.ControllerName = "Docs";
            }
        }
    }
}

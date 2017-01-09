using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

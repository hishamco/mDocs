using Microsoft.AspNetCore.Mvc;

namespace mDocs.Controllers
{
    public class DocumentationController : Controller
    {
        [Route("/{*url}")]
        public IActionResult Index(string url)
        {
            if (url == null || url.EndsWith("/"))
            {
                url += "Index";
            }

            return View(url, GetConfig());
        }

        // TODO: Use the config.json instead
        private static dynamic GetConfig()
        {
            var config = new
            {
                siteName = "NET Core Command-Line Interface (CLI)",
                categories = new[]
                {
                    new
                    {
                        name = "",
                        pages = new[]
                        {
                            new {  title = "Overview", url = "./" },
                            new {  title = "Telemetry", url = "telemetry" },
                            new {  title = "Extensibility Model", url = "extensibility" },
                            new {  title = "Test communication protocol", url = "test-protocol" },
                            new {  title = "Continuous Integration", url = "using-ci-with-cli" },
                            new {  title = "dotnet", url = "dotnet" },
                            new {  title = "dotnet new", url = "dotnet-new" },
                            new {  title = "dotnet restore", url = "dotnet-restore" },
                            new {  title = "dotnet run", url = "dotnet-run" },
                            new {  title = "dotnet build", url = "dotnet-build" },
                            new {  title = "dotnet test", url = "dotnet-test" },
                            new {  title = "dotnet pack", url = "dotnet-pack" },
                            new {  title = "dotnet publish", url = "dotnet-publish" },
                            new {  title = "dotnet install-script", url = "dotnet-install-script" },
                            new {  title = "project.json", url = "project-json" },
                            new {  title = "global.json", url = "global-json" }
                        }
                    }
                }
            };

            return config;
        }
    }
}

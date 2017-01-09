# mDocs
Project documentation with Markdown using ASP.NET Core.

### What is mDocs?
mDocs is a simple and easy tool that let you build your project documentation with markdown using [Markdown View Engine](https://github.com/hishamco/MarkdownViewEngine/).

### How can I use it?
1. Run `dotnet-pack` command on the [Markdown View Engine](https://github.com/hishamco/MarkdownViewEngine/) project.
2. Use "Manage NuGet Packages" to restore the generated `.nupkg` file.
3. Run `dotnet-restore`.
4. Skip the steps 4 and 5 if you wanna use the default template.
5. Add all of your markdown pages inside the "/Views/Docs/" folder.
6. Add page title by adding **@page title="Page Title"** on the top of each `.md` page.
7. Run `dotnet-run`.
8. Open the browser with **localhost:5000/**.

After that you will be able to browse your documentation with the default theme [Read the docs](https://readthedocs.org).

### Limitation

While the project is thightly couple on [Markdown View Engine](https://github.com/hishamco/MarkdownViewEngine/), so there 're some missing features such as:
- Project documentation name should be configurable.
- Generating the pages navigation menu in `_Layout.md`.
- Edit pages in GitHub.

I'm working hard on the [Markdown View Engine](https://github.com/hishamco/MarkdownViewEngine/) to support as much as I can, so hopefully one day those limitation will gone.

**Hint:** The project came up with a sample documentation for .NET Core Comand-Line Interface (CLI), which is shown in the figure below.

![ScreenShot](https://raw.githubusercontent.com/hishamco/mDocs/master/ScreenShot.png)
@page title="global.json reference"

# global.json reference

The global.json file is used on .NET Core projects to define the solution metadata. This file is used when the [dotnet-restore](dotnet-restore.md) command is invoked to restore the dependencies of a .NET Core project.
In this reference topic, you'll see the list of the properties you can define in your global.json file.

## projects
Type: String[]

Specifies which folders the build system should search for projects when resolving dependencies. The build system will only search top-level child folders.

For example:

```json
{
    "projects": [ "src", "test" ]
}
```

## packages
Type: String

The location to store packages.

For example:
```json
{
    "packages": "packages-dir"
}
```

## sdk
Type: Object

Specifies information about the SDK.

### version
Type: String

The version of the SDK to use.

For example:

```json
{
    "sdk": {
        "version": "1.0.0-preview2-003121"
    }
}
```

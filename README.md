# AnyPackage.Templates

[![nuget-image]][nuget-site]
[![cf-image]][cf-site]

[nuget-image]: https://img.shields.io/nuget/dt/AnyPackage.Templates
[cf-image]: https://img.shields.io/codefactor/grade/github/anypackage/templates
[nuget-site]: https://www.nuget.org/packages/AnyPackage.Templates
[cf-site]: https://www.codefactor.io/repository/github/anypackage/templates

This repository contains the source for the .NET project templates.

## Install Template

```shell
dotnet new install AnyPackage.Templates
```

## New Project

The following command will create a new `AnyPackage` project with a package provider class called `MyProvider` in an output folder called `MyProvider`.

```shell
dotnet new anypackage -M 'MyProvider' -o MyProvider
```

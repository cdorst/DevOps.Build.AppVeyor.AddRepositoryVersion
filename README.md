# DevOps.Build.AppVeyor.AddRepositoryVersion

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-addrepositoryversion.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-addrepositoryversion)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion)

## Description

Function adds the given repository build information to an Azure Storage Table ledger

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Build.AppVeyor.GetAzureTable](https://github.com/CDorst/DevOps.Build.AppVeyor.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.GetAzureTable)
[CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder](https://github.com/CDorst/DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-azurestoragetableversionledg.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-azurestoragetableversionledg) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableVersionLedger.Builder)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AddRepositoryVersion)

## Version

1.0.9

## Metaproject

DevOps.Build.AppVeyor.AddRepositoryVersion is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)


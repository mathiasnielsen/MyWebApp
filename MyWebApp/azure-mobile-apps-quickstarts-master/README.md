# QuickStarts for Microsoft Azure Mobile Apps
 
With Microsoft Azure Mobile Apps you can add a scalable backend to your connected client applications in minutes.
To learn more, visit our [Developer Center](http://azure.microsoft.com/en-us/develop/mobile/).

## Getting Started

If you are new to Mobile Apps, you can get started by following our tutorials for connecting your Mobile
Apps cloud backend to [Windows Store apps](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-windows-store-dotnet-get-started/),
[iOS apps](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-ios-get-started/),
and [Android apps](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-android-get-started/).  Tutorials are also available for Xamarin 
[Android](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-xamarin-android-get-started/), 
[iOS](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-xamarin-ios-get-started/), and 
[Forms](https://azure.microsoft.com/en-us/documentation/articles/app-service-mobile-xamarin-forms-get-started/) apps.

## Download Source Code

To get the source code of our SDKs and samples via **git** just type:

    git clone https://github.com/Azure/azure-mobile-apps-quickstarts.git
    cd ./azure-mobile-apps-quickstarts/
 
## Quickstarts Usage Instructions

The Azure Portal helps you get started quickly with Mobile Apps by providing a set of quickstarts for the supported client and server platforms. The quickstarts are customised by the Azure Portal to work with the Mobile App cloud backend you are downloading it for.

Alternatively, you can build the quickstarts yourself for use with your Mobile Apps cloud backend.

### Building Quickstarts For Uploading To Azure Portal

From the command line, run 

    C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe .\Microsoft.WindowsAzure.Mobile.Build.msbuild

The build script downloads latest official nuget packages, updates quickstarts with required versions and dependencies, and packs required projects to appropriate quickstarts.

#### Prerequisites

.Net Framework 4.0.

### Building And Using The Quickstarts Yourself

#### Cordova Client

To build the Azure Mobile Apps Cordova Client yourself, refer the [Cordova Client README](./client/cordova/README.md)

## Future of Azure Mobile Apps
 
Microsoft is committed to fully supporting Azure Mobile Apps, including **support for the latest OS release, bug fixes, documentation improvements, and community PR reviews**. Please note that the product team is **not currently investing in any new feature work** for Azure Mobile Apps. We highly appreciate community contributions to all areas of Azure Mobile Apps. 

## Contribute Code or Provide Feedback

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

If you would like to become an active contributor to this project please follow the instructions provided in [Microsoft Azure Projects Contribution Guidelines](http://azure.github.com/guidelines.html).

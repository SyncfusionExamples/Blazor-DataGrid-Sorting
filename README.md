# Blazor DataGrid Sorting

## Overview

This repository contains sample applications that demonstrate sorting functionality in the Syncfusion Blazor DataGrid. The repository includes separate implementations for both Blazor Server and Blazor WebAssembly hosting models, allowing developers to explore sorting behavior across different Blazor application types. The samples illustrate how DataGrid sorting can be configured and used to organize displayed records based on user interaction with column headers. These projects serve as a practical starting point for implementing sorting scenarios in Syncfusion Blazor DataGrid applications.

## Key Features

- Demonstrates sorting functionality in the Syncfusion Blazor DataGrid.
- Includes dedicated sample applications for both Blazor Server and Blazor WebAssembly.
- Shows how users can sort Grid data through column interactions.
- Provides reference implementations corresponding to the Syncfusion Blazor DataGrid sorting documentation.
- Includes examples related to multi-sorting scenarios referenced by the repository documentation.
- Includes examples related to custom sorting scenarios referenced by the repository documentation.
- Uses Syncfusion Blazor DataGrid sorting capabilities as documented in the official product documentation.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file from either the `Sorting_Grid_Server` or `Sorting_Grid_Wasm` project folder.
3. Restore all NuGet packages.
4. Set the selected project as the startup project if required.
5. Build the solution.
6. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to either the `Sorting_Grid_Server` or `Sorting_Grid_Wasm` project directory.

```bash
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `Sorting_Grid_Server/` — contains the Blazor Server sample application demonstrating Syncfusion Blazor DataGrid sorting.
- `Sorting_Grid_Wasm/` — contains the Blazor WebAssembly sample application demonstrating Syncfusion Blazor DataGrid sorting.
- `Sorting_Grid_Server/Pages/` — contains the Blazor pages that render the DataGrid sorting examples. 
- `Sorting_Grid_Wasm/Pages/` — contains the Blazor pages that render the DataGrid sorting examples. 

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to this feature, see: https://blazor.syncfusion.com/documentation/datagrid/sorting

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
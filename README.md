# SimpleApiBlazorHybridApp

This project is a basic example of a .NET MAUI Blazor Hybrid application that demonstrates fetching data from a remote API and displaying it in a table. It uses the `HttpClient` to fetch data and the Blazor framework for the UI.

## Overview

This application retrieves a list of monkeys from a JSON endpoint and displays their image, name, and details in a table. This project serves as a starting point for learning how to integrate APIs into .NET MAUI Blazor Hybrid apps.

## Technologies Used

*   **C#:** The primary programming language for the application logic.
*   **.NET MAUI:** The framework for building cross-platform native applications.
*   **Blazor:**  The UI framework for building interactive web UIs with C#.
*   **HttpClient:** Used for making HTTP requests to an API.
*   **JSON:**  The data format used to communicate with the API.

## Prerequisites

Before running this project, ensure you have the following installed:

*   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher.
*   Visual Studio 2022 or Visual Studio Code with the appropriate extensions for .NET MAUI development.
*   A basic understanding of .NET, C#, MAUI and Blazor.

## Setup

1.  **Clone the Repository:**

    ```bash
    git clone [your-repository-url]
    cd SimpleApiBlazorHybridApp
    ```
2.  **Restore NuGet Packages:**

    ```bash
    dotnet restore
    ```
   Or, you can restore the packages within Visual Studio through the NuGet Package Manager.

3.  **Build the Project:**

    ```bash
    dotnet build
    ```
    Or you can build the project using Visual Studio.

## Usage

1.  **Run the Application:**

    ```bash
    dotnet run -f net8.0-windows10.0.19041.0
    ```
    *   You may need to change the target framework (e.g., `net8.0-android`, or `net8.0-ios`) depending on the platform you wish to target.
    Or you can run the project from Visual Studio

2.  **View the Application:**

    The application will launch, displaying a table with monkey information fetched from the API.

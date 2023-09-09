# aiKart

## Overview

`aiKart` is a flashcard study helper app built with ASP.NET Core and React. The project aims to facilitate collaborative development and meets various requirements including LINQ, file streams, dependency injection, and more.

## System Requirements

- .NET SDK (5.0 or later)
- Node.js (14.x or later)
- npm (6.x or later)
- Git (optional but recommended)

## Initial Setup

### 1. Clone the Repository (Optional)

```bash
git clone <repository_url>
```

Navigate to the cloned directory.

```bash
cd aiKart
```

### 2. Install .NET Dependencies

```bash
dotnet restore
```

### 3. Install Node.js Dependencies

Navigate to the `ClientApp` folder within your project directory and run:

```bash
npm install
```

## How to Run

### Backend

To run the backend, navigate to the project directory and execute:

```bash
dotnet run
```

This will start the ASP.NET Core backend server. By default, it should run on `https://localhost:7006` and `http://localhost:5277` as per your `launchSettings.json`.

### Frontend

The frontend should automatically be served by the backend through a development proxy when you run `dotnet run`. You can access it by navigating to the backend server URL in your web browser.

## Additional Tools

### ESLint & Prettier

For consistent code styling, it's recommended to set up ESLint and Prettier. These can be installed as development dependencies and integrated into your IDE.

### Unit Testing

For backend, you can use xUnit which integrates well with the .NET ecosystem.
For frontend, the React project template often comes with Jest.

To run backend tests:

```bash
dotnet test
```

To run frontend tests, navigate to the `ClientApp` folder and run:

```bash
npm test
```

## Troubleshooting

1. **dotnet command not found**
   - Make sure the .NET SDK is installed and the `PATH` is set correctly.
   
2. **npm command not found**
   - Make sure Node.js and npm are installed and the `PATH` is set correctly.

3. **Separate CMD Window for Server**
   - This is expected behavior when running both the frontend and backend through a single command. The separate window hosts a development proxy for rerouting requests from the frontend to the backend.

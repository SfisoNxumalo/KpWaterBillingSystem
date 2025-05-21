
# Contributing

Thank you for your interest in contributing to the KP Water Billing System! Don't worry I will take you through it step-by-step, as well as provide you with guidance even if you do not know anything about programming.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) installed
- Visual Studio or Visual Studio Code
- Git
- SQL Server Management Studio

## Setup Instructions
1. Clone the repo:

   git clone https://github.com/SfisoNxumalo/KpWaterBillingSystem.git

```
    cd .\App\KpManagementSystemAPI\
```


2. Restore dependencies:
```bash
   dotnet restore
```


## Coding Standards

* Follow C# naming conventions.
* Repository Pattern
* Dependency Injection
* Use meaningful commit messages.
* Git flow
* Run tests before submitting or PRs will fail:

  ```bash
  dotnet test
  ```


## Submitting a Pull Request

1. Fork the repo.
2. Pick an issue labeled `good-first-issue`.
3. Create a new branch: `git checkout -b feature/your-feature`
4. Commit your changes and push.
5. Submit a pull request with a detailed description.

## Code Reviews

* PRs must pass CI tests.
* At least 1 reviewer approval is required.
`
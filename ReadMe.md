# Calculator App

A simple console-based calculator built with C# and .NET. It performs basic arithmetic operations and lets you run multiple calculations in a single session.

## Features

- Addition, subtraction, multiplication, and division
- Division-by-zero protection
- Repeat calculations without restarting the app
- 🚧 Input validation for non-numeric input (in progress on the `feature/input-validation` branch)

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Project Structure

```
CalculatorApp/
├── CalculatorApp.slnx
└── CalculatorApp/
    ├── CalculatorApp.csproj
    └── Program.cs
```

## Getting Started

Clone the repository:

```bash
git clone https://github.com/mohamedAlaaElamer/calculator.git
cd calculator
```

Switch to this branch (if not already on it):

```bash
git checkout feature/input-validation
```

Run the app:

```bash
cd CalculatorApp/CalculatorApp
dotnet run
```

## Usage

1. Enter the first number.
2. Enter the second number.
3. Choose an operation: `+`, `-`, `*`, or `/`.
4. View the result.
5. Choose whether to perform another calculation (`yes`/`no`).

Example session:

```
Welcome to the Calculator!
---------------------------------
Please enter the first number:
10
Please enter the second number:
5
Please enter the operation (+, -, *, /):
+
The result is: 15
Do you want to perform another calculation? (yes/no)
no
Thank you for using the Calculator!
```

## Roadmap

- [ ] Validate that entered numbers are actually numeric before parsing
- [ ] Validate operation input more gracefully
- [ ] Add unit tests

## License

No license specified yet.
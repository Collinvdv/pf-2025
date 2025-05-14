# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Repository Structure

This repository contains C# programming examples organized into weekly topics for a Programming Fundamentals course. Each week focuses on different programming concepts, progressing from basic concepts to more advanced topics:

- Week 1: Hello World basics
- Week 2: Variables and expressions
- Week 3: Conditional statements (if)
- Week 4: Loops (for)
- Week 5: Arrays
- Week 6: File operations
- Week 7: Exception handling
- Week 8: Collections (Lists, Dictionaries)
- Week 9: Methods and the Blackjack example
- Week 10: Object-oriented programming (OO) and Pokemon example

## Development Commands

### Building and Running C# Projects

Each week's folder contains one or more C# projects. To build and run these projects:

```bash
# Navigate to the project directory
cd weekX_topic/

# Build the project
dotnet build

# Run the project
dotnet run
```

### Creating a New C# Project

To create a new project, you can use:

```bash
# Create a new console application
dotnet new console -n ProjectName
```

### Running a Specific Project

If there are multiple projects in a solution:

```bash
# Navigate to the specific project directory
cd path/to/project/

# Run the specific project
dotnet run --project ProjectName.csproj
```

## Code Architecture

### Object-Oriented Programming Structure

Week 10 demonstrates object-oriented programming principles:

1. **Inheritance Hierarchy**:
   - `Person` is the base class
   - `Student` and `Teacher` inherit from `Person`
   - Classes use properties, constructors, and methods

2. **Pokemon Example**:
   - Demonstrates relationships between `Trainer`, `Pokemon`, and `Pokeball` classes
   - Uses lists to manage collections of objects
   - Implements object ownership with the `IsOwned` property

### File Operations

File operations are demonstrated in week 6:
- Reading from files using `StreamReader` and `File.ReadAllLines()`
- Writing to files using `StreamWriter`
- Appending to existing files
- File existence checking with `File.Exists()`

### Collections

Week 8 covers collections:
- Lists (`List<T>`)
- Dictionaries (`Dictionary<TKey, TValue>`)
- Operations like adding, removing, and iterating through collections
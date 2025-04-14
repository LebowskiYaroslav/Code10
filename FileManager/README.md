# Console File Manager

A simple console-based file manager with basic file operations.

## Features

1. File system navigation
2. File operations (copy, move, delete)
3. File information display
4. Paginated output
5. Configuration support
6. State persistence
7. Error handling and logging
8. Command history

## Requirements

- .NET 6.0 SDK

## Installation

1. Clone the repository
2. Run `dotnet build` in the project directory
3. Run `dotnet run` to start the file manager

## Configuration

Create a `config.json` file in the application directory to customize settings:

```json
{
  "pageSize": 20,
  "defaultDirectory": "C:\\"
}
```

## Usage

Basic commands:
- `ls` - List directory contents
- `cd [path]` - Change directory
- `cp [source] [dest]` - Copy file/directory
- `rm [path]` - Delete file/directory
- `info [path]` - Show file/directory info
- `exit` - Exit the program

# Meduza.Agent.ModuleBase

`Meduza.Agent.ModuleBase` is a NuGet package designed to simplify the creation of custom modules for the Meduza project.

---

## Installation

To install the `Meduza.Agent.ModuleBase` NuGet package, use one of the following methods:

### **Using the .NET CLI:**
```bash
dotnet add package Meduza.Agent.ModuleBase --version <latest_version>
```

### **Using the Package Manager Console in Visual Studio:**
```powershell
Install-Package Meduza.Agent.ModuleBase -Version <latest_version>
```

---

## Getting Started

Follow the steps below to start developing a custom module:

### 1. **Implement the `IModule` Interface**
The `IModule` interface serves as the foundation for all modules. Create a new class that implements this interface.

```csharp
using Meduza.Agent.ModuleBase;

public class MyCustomModule : IModule
{
    public string Name => "MyCustomModule";
    public List<ICommand> Commands { get; set; } = new List<ICommand>();
}
```

### 2. **Create Custom Commands**
Commands are at the core of the module's functionality. Each command should implement the `ICommand` interface.

```csharp
using Meduza.Agent.ModuleBase;

public class HelloWorldCommand : ICommand
{
    public string Name => "HelloWorld";
    public string Execute(string[] parameters)
    {
        return "Hello, World!";
    }
}
```

---

## Example Project

For a usage example, check out the [Meduza.ListDirectory repository](https://github.com/ksel172/Meduza.ListDirectory).

---

## Contributing

Any contributions are welcome! If you encounter issues or have ideas for improvement, feel free to submit a pull request or open an issue on the [GitHub repository](https://github.com/ksel172/Meduza.Agent.ModuleBase).

---

## License

This package is licensed under the [MIT License](LICENSE).

---
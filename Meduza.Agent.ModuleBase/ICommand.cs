using System.IO;

namespace Meduza.Agent.ModuleBase
{
    public interface ICommand
    {
        string Name { get; }

        Stream OutputStream { get; set; }

        string Execute(string[] args = null);
    }
}

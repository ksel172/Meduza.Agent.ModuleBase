using System.Collections.Generic;

namespace Meduza.Agent.ModuleBase
{
    public interface IModule
    {
        string Name { get; }

        List<ICommand> Commands { get; set; }
    }
}

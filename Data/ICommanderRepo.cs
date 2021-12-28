using System.Collections.Generic;
using commander.Models;
 
namespace commander.Data{

    public interface  ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command cmd);
        bool SaveChanges();
        void UpdateCommand(Command cmd);
         
    }
}
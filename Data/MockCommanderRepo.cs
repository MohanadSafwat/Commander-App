// using System.Collections.Generic;
// using commander.Models;

// namespace commander.Data
// {
//     public class MockCommanderRepo : ICommanderRepo
//     {
//         public void CreateCommand(Command cmd)
//         {
//             throw new System.NotImplementedException();
//         }

//         public IEnumerable<Command> GetAllCommands()
//         {
//             var commands = new List<Command>{
//                 new Command{
//                     Id = 0,
//                     HowTo = "Boil an egg",
//                     Line = "Boil water",
//                     Platform = "Kattke and Pan"
//                 },
//                 new Command{
//                     Id = 1,
//                     HowTo = "Cut bread",
//                     Line = "Get a knife",
//                     Platform = "Knife and choping bread"
//                 },
//                 new Command{
//                     Id = 2 ,
//                     HowTo = "Make a cup of tea",
//                     Line = "Place teabag in cup",
//                     Platform = "Kattke and cup"
//                 },

//             };
//             return commands;
//         }

//         public Command GetCommandById(int id)
//         {
//             return new Command
//             {
//                 Id = 0,
//                 HowTo = "Boil an egg",
//                 Line = "Boil water",
//                 Platform = "Kattke and Pan"
//             };
//         }

//         public bool SaveChanges()
//         {
//             throw new System.NotImplementedException();
//         }
//     }
// }
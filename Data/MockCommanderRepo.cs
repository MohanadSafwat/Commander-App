using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{
    public class MockCommandRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{
                    id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "Kattke and Pan"
                },
                new Command{
                    id = 1,
                    HowTo = "Cut bread",
                    Line = "Get a knife",
                    Platform = "Knife and choping bread"
                },
                new Command{
                    id = 2 ,
                    HowTo = "Make a cup of tea",
                    Line = "Place teabag in cup",
                    Platform = "Kattke and cup"
                },

            };
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Platform = "Kattke and Pan"
            };
        }
    }
}
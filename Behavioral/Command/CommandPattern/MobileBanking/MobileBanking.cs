using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBanking
{
    internal class MobileBanking
    {
        Command? command;
        public Command? Command
        {
            set
            {
                if (value.ClassName == "Deposit")
                {
                    Console.WriteLine("Mobile banking can't use Deposit command");
                    return;
                }
                command = value;
            }
        }
        public MobileBanking() { command = null; }
        public void executeCommand()
        {
            if (command != null)
            {
                command.execute();
            }
        }
    }
}

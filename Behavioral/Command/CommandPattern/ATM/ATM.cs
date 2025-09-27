using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        Command? command;
        public Command? Command { set => command = value; }
        public ATM() { Command = null; }
        public void executeCommand()
        {
            if (command != null)
            {
                command.execute();
            }
        }
    }
}

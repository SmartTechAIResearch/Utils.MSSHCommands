using System.Collections.Generic;

namespace msshcommands {
    public class CommandHistory : LinkedList<string> {
        private static CommandHistory _instance = new CommandHistory();

        public static CommandHistory GetInstance() { return _instance; }

        public LinkedListNode<string> CurrentCommandHistoryNode { get; set; }

        private CommandHistory() { }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public static CommandManager Instance;
    private Stack<ICommand> _history = new Stack<ICommand>();

    void Awake(){ Instance = this; }

    public void RunCommand(ICommand command)
    {
        command.Execute();
        _history.Push(command); 
    }

    public void UndoLastCommand()
    {
        if (_history.Count > 0)
        {
            ICommand lastCommand = _history.Pop();
            lastCommand.Undo(); 
        }
}
}

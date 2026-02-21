using Memento.Domain.Interfaces;

namespace Memento.Application;

public class EditorMediator : IEditorMediator
{
    private readonly Stack<IEditorCommand> _undo = new();
    private readonly Stack<IEditorCommand> _redo = new();

    public void Execute(IEditorCommand command)
    {
        command.Execute();
        _undo.Push(command);
        _redo.Clear();
    }

    public void Undo()
    {
        if (_undo.Count == 0) return;

        var cmd = _undo.Pop();
        cmd.Undo();
        _redo.Push(cmd);
    }

    public void Redo()
    {
        if (_redo.Count == 0) return;

        var cmd = _redo.Pop();
        cmd.Execute();
        _undo.Push(cmd);
    }
}
namespace Memento.Domain.Interfaces;

public interface IEditorCommand
{
    void Execute();
    void Undo();
}

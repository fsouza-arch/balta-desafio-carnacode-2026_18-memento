namespace Memento.Domain.Interfaces;

public interface IEditorMediator
{
    void Execute(IEditorCommand command);
    void Undo();
    void Redo();
}

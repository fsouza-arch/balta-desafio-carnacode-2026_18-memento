using Memento.Domain.Interfaces;
using Memento.Domain.Models;

namespace Memento.Domain.Commands;

public class FilterCommand : IEditorCommand
{
    private readonly ImageEditor _editor;
    private readonly string _newFilter;
    private string _previous;

    public FilterCommand(ImageEditor editor, string filter)
    {
        _editor = editor;
        _newFilter = filter;
    }

    public void Execute()
    {
        _previous = _editor.ToString();
        _editor.ApplyFilter(_newFilter);
    }

    public void Undo()
    {
        _editor.ApplyFilter(_previous);
    }
}

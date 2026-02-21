using Memento.Domain.Interfaces;
using Memento.Domain.Models;

namespace Memento.Domain.Commands;

public class RotateCommand : IEditorCommand
{
    private readonly ImageEditor _editor;
    private readonly double _degrees;

    public RotateCommand(ImageEditor editor, double degrees)
    {
        _editor = editor;
        _degrees = degrees;
    }

    public void Execute() => _editor.Rotate(_degrees);

    public void Undo() => _editor.Rotate(-_degrees);
}
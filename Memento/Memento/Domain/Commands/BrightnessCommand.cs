using Memento.Domain.Interfaces;
using Memento.Domain.Models;

namespace Memento.Domain.Commands;

public class BrightnessCommand : IEditorCommand
{
    private readonly ImageEditor _editor;
    private readonly int _value;

    public BrightnessCommand(ImageEditor editor, int value)
    {
        _editor = editor;
        _value = value;
    }

    public void Execute() => _editor.ChangeBrightness(_value);

    public void Undo() => _editor.ChangeBrightness(-_value);
}
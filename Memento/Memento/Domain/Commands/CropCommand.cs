using Memento.Domain.Interfaces;
using Memento.Domain.Models;

namespace Memento.Domain.Commands;

public class CropCommand : IEditorCommand
{
    private readonly ImageEditor _editor;
    private readonly int _newW;
    private readonly int _newH;
    private int _oldW;
    private int _oldH;

    public CropCommand(ImageEditor editor, int w, int h)
    {
        _editor = editor;
        _newW = w;
        _newH = h;
    }

    public void Execute()
    {
        // simplificado: normalmente salvaria snapshot leve
        _editor.Crop(_newW, _newH);
    }

    public void Undo()
    {
        _editor.Crop(_oldW, _oldH);
    }
}
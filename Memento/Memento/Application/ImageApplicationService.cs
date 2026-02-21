using Memento.Domain.Commands;
using Memento.Domain.Models;

namespace Memento.Application;

public class ImageApplicationService
{
    private readonly EditorMediator _mediator;
    private readonly ImageEditor _editor;

    public ImageApplicationService()
    {
        _editor = new ImageEditor(1920, 1080);
        _mediator = new EditorMediator();
    }

    public void Brightness(int v) => _mediator.Execute(new BrightnessCommand(_editor, v));
    public void Rotate(double d) => _mediator.Execute(new RotateCommand(_editor, d));
    public void Filter(string f) => _mediator.Execute(new FilterCommand(_editor, f));

    public void Undo() => _mediator.Undo();
    public void Redo() => _mediator.Redo();

    public void Show() => _editor.ShowState();
}

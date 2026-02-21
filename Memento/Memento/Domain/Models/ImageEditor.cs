namespace Memento.Domain.Models;

public class ImageEditor
{
    private byte[] _pixels;
    private int _width;
    private int _height;
    private int _brightness;
    private string _filter = "None";
    private double _rotation;

    public ImageEditor(int width, int height)
    {
        _width = width;
        _height = height;
        _pixels = new byte[width * height * 3];
    }

    internal void ChangeBrightness(int value) => _brightness += value;

    internal void Rotate(double degrees) => _rotation += degrees;

    internal void ApplyFilter(string filter) => _filter = filter;

    internal void Crop(int width, int height)
    {
        _width = width;
        _height = height;
        Array.Resize(ref _pixels, width * height * 3);
    }

    public void ShowState()
    {
        Console.WriteLine($"{_width}x{_height} | B:{_brightness} | F:{_filter} | R:{_rotation}");
    }
}

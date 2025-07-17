namespace RobotWars;

public class Arena(int width = 5, int height = 5)
{
    private int Width { get; } = width;
    private int Height { get; } = height;

    public bool IsInside(int x, int y)
    {
        return x >= 0 && x < Width && y >= 0 && y < Height;
    }
}

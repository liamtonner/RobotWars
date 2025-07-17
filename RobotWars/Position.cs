namespace RobotWars;

public class Position(int x, int y, Direction heading)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public Direction Heading { get; set; } = heading;

    public override string ToString() => $"{X}, {Y}, {Heading}";
}

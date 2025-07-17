namespace RobotWars;

public class Robot(Arena arena, Position startPosition)
{
    private Position Position { get; } = startPosition;
    private int Penalties { get; set; } 

    public void ExecuteInstructions(string instructions)
    {
        foreach (var cmd in instructions)
        {
            ExecuteInstruction(cmd);
        }
    }

    private void ExecuteInstruction(char instruction)
    {
        switch (instruction)
        {
            case 'L':
                TurnLeft();
                break;
            case 'R':
                TurnRight();
                break;
            case 'M':
                MoveForward();
                break;
        }

        ReportStatus();
    }

    private void TurnLeft()
    {
        Position.Heading = Position.Heading switch
        {
            Direction.N => Direction.W,
            Direction.W => Direction.S,
            Direction.S => Direction.E,
            Direction.E => Direction.N,
            _ => Position.Heading
        };
    }

    private void TurnRight()
    {
        Position.Heading = Position.Heading switch
        {
            Direction.N => Direction.E,
            Direction.E => Direction.S,
            Direction.S => Direction.W,
            Direction.W => Direction.N,
            _ => Position.Heading
        };
    }

    private void MoveForward()
    {
        int newX = Position.X, newY = Position.Y;

        switch (Position.Heading)
        {
            case Direction.N: newY++; break;
            case Direction.S: newY--; break;
            case Direction.E: newX++; break;
            case Direction.W: newX--; break;
        }

        if (arena.IsInside(newX, newY))
        {
            Position.X = newX;
            Position.Y = newY;
        }
        else
        {
            Penalties++;
        }
    }
    
    public int GetXPosition()
    {
        return Position.X;
    }
    public int GetYPosition()
    {
        return Position.Y;
    }

    public Direction GetHeading()
    {
        return Position.Heading;
    }
    public int GetPenalties()
    {
        return Penalties;
    }

    private void ReportStatus()
    {
        Console.WriteLine($"Position: {Position.X}, {Position.Y}, {Position.Heading} | Penalties: {Penalties}");
    }
}

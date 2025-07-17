namespace RobotWars.Tests;

public class RobotTests
{
    private Arena _arena;

    [SetUp]
    public void Setup()
    {
        _arena = new Arena();
    }

    [TestCase(0, 2, Direction.E, "MLMRMMMRMMRR", 4, 1, Direction.N, 0)]
    [TestCase(4, 4, Direction.S, "LMLLMMLMMMRMM", 0, 1, Direction.W, 1)]
    [TestCase(2, 2, Direction.W, "MLMLMLMRMRMRMRM", 2, 2, Direction.N, 0)]
    [TestCase(1, 3, Direction.N, "MMLMMLMMMMM", 0, 0, Direction.S, 3)]
    public void Robot_ExecutesScenarioCorrectly(
        int startX, int startY, Direction startHeading,
        string instructions,
        int expectedX, int expectedY, Direction expectedHeading,
        int expectedPenalties)
    {
        var robot = new Robot(_arena, new Position(startX, startY, startHeading));
        robot.ExecuteInstructions(instructions);
        Assert.That(expectedX, Is.EqualTo(robot.GetXPosition()));
        Assert.That(expectedY, Is.EqualTo(robot.GetYPosition()));
        Assert.That(expectedHeading, Is.EqualTo(robot.GetHeading()));
        Assert.That(expectedPenalties, Is.EqualTo(robot.GetPenalties()));
    }
}
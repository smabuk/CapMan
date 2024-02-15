using static CapMan.Direction;

namespace CapMan;

public enum Direction
{
    Up,
    Down,
    Left,
    Right
}

public static class DirectionExtensions
{
    public static readonly IEnumerable<Direction> Directions = Enum.GetValues<Direction>();

    public static Direction Opposite(this Direction d) => d switch
    {
        Up => Down,
        Down => Up,
        Left => Right,
        Right => Left,
        _ => throw new Exception($"Unknown direction {d}"),

    };

    public static bool IsOpposite(this Direction d0, Direction d1) => (d0, d1) switch
    {
        (Up, Down) => true,
        (Down, Up) => true,
        (Left, Right) => true,
        (Right, Left) => true,
        _ => false,
    };

    public static IEnumerable<Direction> Turns(this Direction currentDirection) => Directions.Where(d => d != currentDirection);

}
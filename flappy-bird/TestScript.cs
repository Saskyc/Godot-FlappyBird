using System.Globalization;
using Godot;

namespace FlappyBird;

public partial class TestScript : Label
{
    public static float C = 0;
    
    public override void _Ready()
    {
        C += 0.5f;
        GD.Print("Started Test script");
        Text = C.ToString(CultureInfo.InvariantCulture);
        Position = new Vector2(C, C);
    }
}
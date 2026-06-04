using Godot;

namespace FlappyBird;

public partial class BirdScript : Sprite2D
{
	[Export]
	public Camera2D Camera;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public float Time = 0;

	public override void _Input(InputEvent @event)
	{
		if (@event.ToString().Contains("Motion")) return;
		GD.Print(@event.GetType().Name);
		if (@event is InputEventMouseButton mouseButton)
		{
			//Rigid.ApplyForce(new Vector2(0, 1).Normalized());
		}
		base._Input(@event);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Camera.Position = new Vector2(Position.X, Position.Y);
		GD.Print(Position);
	}

	public bool Jumping = false;

	public Vector2 Peak = Vector2.Zero;
	public Vector2 Original = Vector2.Zero;
}

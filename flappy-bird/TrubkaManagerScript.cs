using FlappyBird;
using Godot;
using System;

public partial class TrubkaManagerScript : Node
{
	[Export]
	public Trubka MainAsset;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		MainAsset.D = true;
		MainAsset.Scale = new Vector2(0, 0);
	}

	public double T = 0;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		T += delta;
		if (T < 1) return;
		T = 0;
		var tween = MainAsset.Duplicate();
		
		if(tween is not Trubka trubka)
		{
			GD.PrintErr("Wrong creation");
			return;
		}
		AddChild(tween);
		GD.Print("Created");
		trubka.Position = new Vector2(MainAsset.Position.X, 994);
		trubka.Scale = new Vector2(1, 1);
	}
}

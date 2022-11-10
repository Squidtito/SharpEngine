using Godot;
using System;
public partial class MainMenu : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print("Hello World!");
		Godot.Sprite2D mylife = this.GetNode<Godot.Sprite2D>("Icon");
		mylife.Position += new Vector2(10,0);
	}
}

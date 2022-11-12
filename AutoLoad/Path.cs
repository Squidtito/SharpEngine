using Godot;
using System;

public partial class Path : Node
{
	// Called when the node enters the scene tree for the first time.
	public static string find_character(string character)
	{
		GD.Print("Loading character: " + character);
		string ez="res://Characters/" + character + "/";
		GD.Print(ez);
		return ez;
	}
}

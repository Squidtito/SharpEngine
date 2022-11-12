using Godot;
using System;

public partial class XmlConverter : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public void Split(string image)
	{
		
	}
	public override void _Ready()
	{
		var CHAR_PNG = GD.Load<Texture2D>(Path.find_character("bf") + "character.png");
		string CHAR_XML = Path.find_character("bf") + "character.xml";
		XMLParser xml = new XMLParser();
		xml.Open(CHAR_XML);
		while (xml.Read() == Error.Ok);
			GD.Print(xml.GetNodeName()+"-");
			
		GD.Print(xml.Read());
		GD.Print(xml.GetNamedAttributeValue("frameWidth")+ "yes");
		AtlasTexture ATLAS = new AtlasTexture();
		ATLAS.Atlas = CHAR_PNG;
		//<SubTexture name="BF idle dance0000" x="0" y="2344" width="406" height="392" frameX="-1" frameY="-20" frameWidth="411" frameHeight="412"/>
		ATLAS.Region = new Rect2(0,2344,406,392);
		var sprite = GetNode<Sprite2D>("Texture");
		sprite.Texture = ATLAS;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

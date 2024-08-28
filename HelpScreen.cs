using Godot;
using System;

public partial class HelpScreen : CanvasLayer
{
	[Signal]
	public delegate void ToggleMuteEventHandler();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Hide();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnBackButtonPressed() {
		Hide();
	}

	private void OnMuteButtonToggled(bool newState) {
		EmitSignal(SignalName.ToggleMute);
	}
}

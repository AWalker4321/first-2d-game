using Godot;
using System;

public partial class Player : Area2D
{
	[Signal]
	public delegate void HitEventHandler();
	[Export]
	public int Speed { get; set; } = 400;

	public Vector2 ScreenSize;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
		Hide();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//current velocity
		var velocity = Vector2.Zero;

		//get movement
		if (Input.IsActionPressed("move_right")) {
			velocity.X += 1;
		}
		if (Input.IsActionPressed("move_left")) {
			velocity.X -= 1;
		}
		if (Input.IsActionPressed("move_up")) {
			velocity.Y -= 1;
		}
		if (Input.IsActionPressed("move_down")) {
			velocity.Y += 1;
		}

		//get the animation part of the player
		var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

		//movement prep
		if (velocity.Length() > 0) {
			velocity = velocity.Normalized() * Speed; //normalized so diagnal movement isn't faster than single axis movement
			animatedSprite2D.Play();
		} else {
			animatedSprite2D.Stop();
		}

		//move the player
		Position += velocity * (float)delta;
		Position = new Vector2( //ensure the player stays in the screen bounries
			x: Mathf.Clamp(Position.X, 0, ScreenSize.X),
			y: Mathf.Clamp(Position.Y, 0, ScreenSize.Y)
		);

		//choose animation to play
		animatedSprite2D.FlipV = velocity.Y > 0;
		if (velocity.X != 0) {
			animatedSprite2D.Animation = "walk";
			animatedSprite2D.FlipH = velocity.X < 0;
		}
		else if (velocity.Y != 0) {
			animatedSprite2D.Animation = "up";
		}
	}

	private void OnBodyEntered(Node2D body) {
		Hide(); //Player disappears after being hit
		EmitSignal(SignalName.Hit);
		//Must be deferred as we can't change physics properties on a physics callback
		GetNode<CollisionShape2D>("CollisionShape2D").SetDeferred(CollisionShape2D.PropertyName.Disabled, true);
	}
	
	public void Start(Vector2 position) {
		Position = position;
		Show();
		GetNode<CollisionShape2D>("CollisionShape2D").Disabled = false;
	}
}

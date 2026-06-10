using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace FlappyBird
{
    public partial class JumpScript : CharacterBody2D
    {
        [Export] public float MoveSpeed = 200;

        public override void _Ready()
        {
            JumpVelocity = (float)(2.0 * JumpHeight / JumpTimeToPeak * -1.0);
            JumpGravity = (float)((float)(-2.0 * JumpHeight / (JumpTimeToPeak * JumpTimeToPeak)) * -1.0);
            FallGravity = (float)((-2.0 * JumpHeight) / (JumpTimeToDescent * JumpTimeToDescent) * -1.0);
            base._Ready();
        }

        [Export] public float JumpHeight = 30;
        [Export] public float JumpTimeToPeak = 0.5f;
        [Export] public float JumpTimeToDescent = 0.25f;

        public float JumpVelocity;
        public float JumpGravity;
        public float FallGravity;

        public override void _PhysicsProcess(double delta)
        {
            Velocity = new Vector2(Velocity.X, (float)(Gravity * delta));
            if (Input.IsActionJustPressed("jump")) 
            {
                AirJump();
            }
            MoveAndSlide();
            base._PhysicsProcess(delta);
        }

        public float Gravity
        {
            get
            {
                if (Velocity.Y < 0)
                {
                    return JumpGravity;
                }
                return FallGravity;
            } 
        }

        public void AirJump() 
        {
            Velocity = new Vector2(Velocity.X, JumpVelocity);
        }
    }
}

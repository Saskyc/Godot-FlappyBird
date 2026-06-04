using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird
{
	public partial class Trubka : Sprite2D
	{
		public bool D = false;

		public override void _Process(double delta)
		{
			if (D) return;
			Position += new Vector2(-15f, 0);
			base._Process(delta);
		}
	}
}

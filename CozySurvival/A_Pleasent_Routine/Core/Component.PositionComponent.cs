// Core/Components/PositionComponent.cs
using Microsoft.Xna.Framework;

namespace A_Pleasant_Routine.Core.Components
{
	public class PositionComponent : Component
	{
		public Vector2 Position { get; set; }

		public PositionComponent(Vector2 position)
		{
			Position = position;
		}
	}
}

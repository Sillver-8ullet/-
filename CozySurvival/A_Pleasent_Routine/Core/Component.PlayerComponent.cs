// Core/Components/PlayerComponent.cs
namespace A_Pleasant_Routine.Core.Components
{
	public class PlayerComponent : Component
	{
		public float Speed { get; set; }

		public PlayerComponent(float speed)
		{
			Speed = speed;
		}
	}
}

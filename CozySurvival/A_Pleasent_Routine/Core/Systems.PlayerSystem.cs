// Core/Systems/PlayerSystem.cs
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using A_Pleasant_Routine.Core.Components;

namespace A_Pleasant_Routine.Core.Systems
{
	public class PlayerSystem : System
	{
		public override void Update(GameTime gameTime)
		{
			foreach (var entity in Entities)
			{
				PlayerComponent player = entity.GetComponent<PlayerComponent>();
				PositionComponent position = entity.GetComponent<PositionComponent>();

				if (player != null && position != null)
				{
					KeyboardState keyboardState = Keyboard.GetState();
					Vector2 newPosition = position.Position;

					if (keyboardState.IsKeyDown(Keys.W))
						newPosition.Y -= player.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
					if (keyboardState.IsKeyDown(Keys.S))
						newPosition.Y += player.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
					if (keyboardState.IsKeyDown(Keys.A))
						newPosition.X -= player.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
					if (keyboardState.IsKeyDown(Keys.D))
						newPosition.X += player.Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

					position.Position = newPosition;
				}
			}
		}
	}
}


using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A_Pleasant_Routine
{
	internal class Player {
		private Texture2D _texture;
		private float _rotation;

		public Vector2 Postition;
		public Vector2 Origin;

		public float RotationVelocity = 3f;
		public float linearVelocity = 4f;

		public Player(Texture2D texture) { 
			_texture = texture;
		}

		public void Update(){
			if(Keyboard.GetState().IsKeyDown(Keys.Left)){
				_rotation -= MathHelper.ToRadians(RotationVelocity);
			} else if(Keyboard.GetState().IsKeyDown(Keys.Right)){
				_rotation += MathHelper.ToRadians(RotationVelocity);
			}

			var direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - _rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - _rotation));

			if(Keyboard.GetState().IsKeyDown(Keys.Up)){
				Postition += direction * linearVelocity;
			} else if(Keyboard.GetState().IsKeyDown(Keys.Down)){
				Postition -= direction * linearVelocity;	
			}
		}

		public void Draw(SpriteBatch spriteBatch) {
			spriteBatch.Draw(_texture, Postition, null, Color.White, _rotation, Origin, 1, SpriteEffects.None, 0f);
		}

		internal void Dispose()
		{
			_texture.Dispose();
		}
	}
}


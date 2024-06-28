// Game1.cs
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using A_Pleasant_Routine.Core;
using A_Pleasant_Routine.Modules.BaseGame;

namespace A_Pleasant_Routine
{
	public class Spirit : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private BaseGame _baseGame;

		Texture2D ballTexture;
		Vector2 ballPosition;
		float ballSpeed;

		public Spirit()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content/bin/DesktopGL";
			IsMouseVisible = true;

			_baseGame = new BaseGame();
		}

		protected override void Initialize()
		{
			// Initialize game systems
			_baseGame.Load();

			base.Initialize();
			
			// TODO: Add your initialization logic here
			ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
			_graphics.PreferredBackBufferHeight / 2);
			ballSpeed = 100f;

			base.Initialize();

		}

		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
			ballTexture = Content.Load<Texture2D>("ball");
		}


		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// Update game systems
			_baseGame.Update(gameTime);

			base.Update(gameTime);

			// TODO: Add your update logic here
			var kstate = Keyboard.GetState();

			if (kstate.IsKeyDown(Keys.Up))
			{
				ballPosition.Y -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
			}

			if (kstate.IsKeyDown(Keys.Down))
			{
				ballPosition.Y += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
			}

			if (kstate.IsKeyDown(Keys.Left))
			{
				ballPosition.X -= ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
			}

			if (kstate.IsKeyDown(Keys.Right))
			{
				ballPosition.X += ballSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
			}

			base.Update(gameTime);

		}

		protected override void Draw(GameTime gameTime)
		{
			_graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here
			_spriteBatch.Begin();
			_spriteBatch.Draw(
				ballTexture,
				ballPosition,
				null,
				Color.White,
				0f,
				new Vector2(ballTexture.Width / 2, ballTexture.Height / 2),
				Vector2.One,
				SpriteEffects.None,
				0f
			);
			_spriteBatch.End();

			base.Draw(gameTime);
		}


		protected override void UnloadContent()
		{
			_baseGame.Unload();
		}
	}
}

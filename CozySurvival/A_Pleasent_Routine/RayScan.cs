using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace A_Pleasant_Routine
{
	internal class RayScan : Game
	{
		/// <summary>
		///		connection between the seen and unseen
		/// </summary>
		private GraphicsDeviceManager _GRAPHICS;
		private SpriteBatch _SPRITE_BATCH;
		private Player _PLAYER;

		private Vector2 _POSITION, _SCALE;

		private float _ROTATION, _LAYER, _PLAYER_SPEED;

		private int _MAP_X, _MAP_Y;

		private int[] _MAP;

		/// <summary>
		///		Construct a new Atman.
		///		attach the soul
		/// </summary>
		public RayScan()
		{
			_GRAPHICS = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content/bin/DesktopGL";
			IsMouseVisible = true;

		}

		/// <summary>
		/// The Initialize method is called after the constructor but before the main game loop (Update/Draw). This is where you can query any required services and load any non-graphic related content.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			_GRAPHICS.IsFullScreen = false;
			_GRAPHICS.ApplyChanges();


			_POSITION = new Vector2(300f, 300f);
			_SCALE = new Vector2(8f, 8f);

			_ROTATION = 0f;
			_LAYER = 1f;
			_PLAYER_SPEED = 100f;

			_MAP_X = 8;
			_MAP_Y = 8;

			_MAP = new int[] {
			   1,1,1,1,1,1,1,1,
			   1,0,1,0,0,0,0,1,
			   1,0,1,0,0,0,0,1,
			   1,0,1,0,0,0,0,1,
			   1,0,0,0,0,0,0,1,
			   1,0,0,0,0,1,0,1,
			   1,0,0,0,0,0,0,1,
			   1,1,1,1,1,1,1,1
			};

			base.Initialize();
		}

		/// <summary>
		/// The LoadContent method is used to load your game content. It is called only once per game, within the Initialize method, before the main game loop starts
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			_SPRITE_BATCH = new SpriteBatch(GraphicsDevice);
			Texture2D texture = Content.Load<Texture2D>("ball");
			_PLAYER = new Player(texture)
			{
				Origin = new Vector2(texture.Width / 2, texture.Height / 2)
			};

		}

		/// <summary>
		/// The Update method is called multiple times per second, and it is used to update your game state (checking for collisions, gathering input, playing audio, etc.).
		/// </summary>
		/// <param name="gameTime"></param>
		protected override void Update(GameTime gameTime)
		{
			KeyboardState kState = Keyboard.GetState();

			_PLAYER.Update();

			base.Update(gameTime);
		}


		/// <summary>
		/// Similar to the Update method, the Draw method is also called multiple times per second. This, as the name suggests, is responsible for drawing content to the screen.
		/// </summary>
		/// <param name="gameTime"></param>
		protected override void Draw(GameTime gameTime)
		{
			base.Draw(gameTime);
			GraphicsDevice.Clear(Color.MediumPurple);

			_SPRITE_BATCH.Begin();
/*
			for (int my = 0; my < _MAP_Y; my++)
			{
				for (int mx = 0; mx < _MAP_X; mx++)
				{
					int wallW = _GRAPHICS.PreferredBackBufferWidth / _MAP_X;
					int wallH = _GRAPHICS.PreferredBackBufferHeight / _MAP_Y;
					int wallX = wallW * mx;
					int wallY = wallH * my;

					Color mapColor = Color.Gray;

					if (_MAP[(my * _MAP_X) + mx] == 1) mapColor = Color.Black; 

					//_SPRITE_BATCH.Draw(_PLAYER, new Rectangle(wallX + 1, wallY + 1, wallW - 2, wallH - 2), mapColor);

				}
			}*/

			_PLAYER.Draw(_SPRITE_BATCH);

			_SPRITE_BATCH.End();

			// TODO: Add your drawing code here

			base.Draw(gameTime);
		}

		protected override void UnloadContent()
		{
			base.UnloadContent();
			_SPRITE_BATCH.Dispose();
			_PLAYER.Dispose();
		}
	}
}

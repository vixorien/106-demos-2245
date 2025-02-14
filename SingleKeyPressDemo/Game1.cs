using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

// Chris Cascioli
// 2/14/25
// Demo of more sophisticated user input (single key press)

namespace SingleKeyPressDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		private SpriteFont font;
		private Color currentColor;
		private Random rng;

		// Details about last frame's input
		private KeyboardState prevKB;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			currentColor = Color.White;
			rng = new Random();

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			font = Content.Load<SpriteFont>("Verdana48");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// Get current keyboard details
			KeyboardState kb = Keyboard.GetState();

			if (kb.IsKeyDown(Keys.Enter) && prevKB.IsKeyUp(Keys.Enter))
			{
				currentColor = new Color(
					rng.Next(256),
					rng.Next(256),
					rng.Next(256));
			}

			// Save this new data for the next frame
			prevKB = kb;

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			_spriteBatch.Begin();
			_spriteBatch.DrawString(
				font,
				"Press Enter to\nchange color!",
				Vector2.One * 10,
				currentColor);
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

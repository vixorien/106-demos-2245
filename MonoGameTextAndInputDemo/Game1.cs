using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/10/25
// Example of text and input in MonoGame

namespace MonoGameTextAndInputDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// Separate SpriteFont for each one we load
		private SpriteFont _fontVerdana24;

		// Variables for a moving tiger
		private Texture2D _ritLogo;
		private Vector2 _ritPosition;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// Load any and all content
			_fontVerdana24 = Content.Load<SpriteFont>("Verdana24");
			_ritLogo = Content.Load<Texture2D>("rit");

			_ritPosition = new Vector2(
				GraphicsDevice.Viewport.Width / 2,
				GraphicsDevice.Viewport.Height / 2);
			_ritPosition.X -= _ritLogo.Width / 2;
			_ritPosition.Y -= _ritLogo.Height / 2;
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			ProcessInput();

			base.Update(gameTime);
		}

		/// <summary>
		/// Handle basic input
		/// </summary>
		private void ProcessInput()
		{
			// Step 1: Get fresh keyboard info
			KeyboardState kb = Keyboard.GetState();

			// Step 2: Check it
			float speed = 5;
			if (kb.IsKeyDown(Keys.W))
			{
				_ritPosition.Y -= speed;
			}
			
			if (kb.IsKeyDown(Keys.S))
			{
				_ritPosition.Y += speed;
			}

			if (kb.IsKeyDown(Keys.A))
			{
				_ritPosition.X -= speed;
			}

			if (kb.IsKeyDown(Keys.D))
			{
				_ritPosition.X += speed;
			}

			// A quick look at mouse input
			MouseState ms = Mouse.GetState();
			if (ms.LeftButton == ButtonState.Pressed)
			{
				// If only this were a boolean...
			}
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			_spriteBatch.Begin();

			// Text ---
			// Draw "drop shadow"
			_spriteBatch.DrawString(
				_fontVerdana24,
				"This is some text, yo!",
				new Vector2(52, 52),
				Color.Black);

			// Draw text itself
			_spriteBatch.DrawString(
				_fontVerdana24,
				"This is some text, yo!",
				new Vector2(50, 50),
				Color.White);

			// Testing out other characters
			_spriteBatch.DrawString(
				_fontVerdana24,
				"This is the first line\nAnother line, please\n!@#$%^&*()",
				new Vector2(50, 150),
				Color.White);

			_spriteBatch.Draw(_ritLogo, _ritPosition, Color.White);

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

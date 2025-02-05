using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/5/25
// First demo of MonoGame: Content loading and drawing

namespace FirstMonoGameDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// Drawing-related data for mario
		private Texture2D marioTexture;
		private Vector2 marioPosition;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// Set up the initial mario position
			marioPosition = new Vector2(0, 0);

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			// Load any and all content files (like images)
			marioTexture = this.Content.Load<Texture2D>("mario");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// Move mario
			marioPosition.X += 5.0f;

			// Check to see if mario went off the screen
			if (marioPosition.X >= GraphicsDevice.Viewport.Width)
			{
				marioPosition.X = -marioTexture.Width;
			}

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			// Start a batch
			_spriteBatch.Begin();

			// Draw mario on the screen
			_spriteBatch.Draw(
				marioTexture, // What are we drawing?
				marioPosition, // Where are we drawing it?
				Color.White); // Color tint? (White = no tint)

			_spriteBatch.Draw(
				marioTexture,
				new Rectangle(100, 0, 600, 200),
				Color.White);

			// End the batch (actually drawing)
			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

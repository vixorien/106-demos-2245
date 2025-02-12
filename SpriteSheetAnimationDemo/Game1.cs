using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/12/25
// Example of frame-by-frame animation with a sprite sheet

namespace SpriteSheetAnimationDemo
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// Animation variables
		private const int TotalSpriteSheetFrames = 4;
		private Texture2D marioSpriteSheet;
		private int currentFrame;
		private float animationSpeedFPS;
		private float secondsPerFrame;
		private float timeCounter;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			currentFrame = 1;
			animationSpeedFPS = 10;
			secondsPerFrame = 1.0f / animationSpeedFPS;
			timeCounter = 0;

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			marioSpriteSheet = Content.Load<Texture2D>("MarioSpriteSheet");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// How much time has passed?  Keep track
			timeCounter += (float)gameTime.ElapsedGameTime.TotalSeconds;
			
			// If we've surpassed the amount of time for a single frame,
			// increment our frame counter
			if (timeCounter >= secondsPerFrame)
			{
				currentFrame++;
				timeCounter -= secondsPerFrame;

				// Loop back to the first frame
				if (currentFrame >= 4)
					currentFrame = 1;
			}

			

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.Black);

			// Draw a single "frame" of my sprite sheet
			_spriteBatch.Begin();

			// Calculate a single source rectangle
			int frameWidth = marioSpriteSheet.Width / TotalSpriteSheetFrames;
			Rectangle srcRect = new Rectangle(
				currentFrame * frameWidth,
				0,
				frameWidth,
				marioSpriteSheet.Height);


			Rectangle destRect = new Rectangle(
				100,
				100,
				srcRect.Width * 3,
				srcRect.Height * 3);

			_spriteBatch.Draw(
				marioSpriteSheet,
				destRect,
				srcRect,
				Color.White);

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

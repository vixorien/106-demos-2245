using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/12/25
// Example of a simple Finite State Machine

namespace FSMDemo
{
	enum GameState
	{
		Menu,
		Options,
		Gameplay,
		Pause
	}

	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private SpriteFont font;

		// Tracking which state our program is in
		private GameState currentState;

		public Game1()
		{
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// Start on the menu
			currentState = GameState.Menu;

			base.Initialize();
		}

		protected override void LoadContent()
		{
			_spriteBatch = new SpriteBatch(GraphicsDevice);

			font = Content.Load<SpriteFont>("Verdana48");
		}

		protected override void Update(GameTime gameTime)
		{
			// ALL states need input, so grab it here first
			KeyboardState kb = Keyboard.GetState();
			
			switch (currentState)
			{
				case GameState.Menu:

					// Check for transition to the options menu and game play
					if (kb.IsKeyDown(Keys.O)) { currentState = GameState.Options; }
					if (kb.IsKeyDown(Keys.Enter)) { currentState = GameState.Gameplay; }

					break;

				case GameState.Options:
					// Check for transitions that matter in this state
					if (kb.IsKeyDown(Keys.Escape)) { currentState = GameState.Menu; }

					break;

				case GameState.Gameplay:
					// Check for transitions that matter in this state
					if (kb.IsKeyDown(Keys.P)) { currentState = GameState.Pause; }

					break;

				case GameState.Pause:
					// Check for transition back to gameplay or main menu
					if (kb.IsKeyDown(Keys.Escape)) { currentState = GameState.Gameplay; }
					if (kb.IsKeyDown(Keys.X)) { currentState = GameState.Menu; }

					break;
			}

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			// We can begin the sprite batch before
			// the switch because ALL states need to draw
			_spriteBatch.Begin();

			switch (currentState)
			{
				case GameState.Menu:
					// "Draw" the main menu
					_spriteBatch.DrawString(
						font,
						"MENU!\n\nO: Options\nEnter: Play game",
						Vector2.Zero,
						Color.White);
					break;

				case GameState.Options:
					// "Draw" the options screen
					_spriteBatch.DrawString(
						font,
						"OPTIONS!\n\nEsc: Exit",
						Vector2.Zero,
						Color.White);
					break;

				case GameState.Gameplay:
					// "Draw" the game play
					_spriteBatch.DrawString(
						font,
						"The Game!\n\nP: Pause",
						Vector2.Zero,
						Color.White);
					break;

				case GameState.Pause:
					// "Draw" the pause screen
					_spriteBatch.DrawString(
						font,
						"PAUSED!\n\nEsc: Resume\nX: Exit",
						Vector2.Zero,
						Color.White);
					break;
			}

			_spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}

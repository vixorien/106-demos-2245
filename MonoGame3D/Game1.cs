using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGame3D
{
	public class Game1 : Game
	{
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;

		// 3D model
		private Model model;

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

			model = Content.Load<Model>("torus");

			BasicEffect fx = model.Meshes[0].Effects[0] as BasicEffect;
			fx.EnableDefaultLighting();
			fx.PreferPerPixelLighting = true;
			fx.DiffuseColor = Color.Purple.ToVector3();
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		float yaw = 0.0f;
		float pitch = 0.0f;
		float roll = 0.0f;

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			yaw += 0.01f;
			pitch += 0.01f;
			roll += 0.01f;

			float sin = MathF.Sin((float)gameTime.TotalGameTime.TotalSeconds);

			// World-space transformations
			Matrix t = Matrix.CreateTranslation(sin * 3, 0, 0);
			Matrix r = Matrix.CreateFromYawPitchRoll(yaw, pitch, roll);
			Matrix s = Matrix.CreateScale(0.02f);
			Matrix world = s * r * t;

			// Camera transformations
			Matrix view = Matrix.CreateLookAt(
				Vector3.Backward * 10,
				Vector3.Zero,
				Vector3.Up);

			Matrix projection = Matrix.CreatePerspectiveFieldOfView(
				MathHelper.PiOver4,
				1.66f, // Should match windowWidth/windowHeight
				0.1f,
				1000.0f);


			model.Draw(world, view, projection);

			base.Draw(gameTime);
		}
	}
}

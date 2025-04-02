using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ShapeUtils;
using System;

namespace DynamicTree_STARTER
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // The three trees
        private Tree treeRed;
        private Tree treeGreen;
        private Tree treeBlue;

		// Random gen
		private Random rng = new Random();

		// Constants for drawing
		private const float BranchAngle = 0.2f;
		private const float BranchLength = 25.0f;
		private const int BranchWidth = 2;

		public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
			_graphics.PreferredBackBufferWidth = 1440;
			_graphics.PreferredBackBufferHeight = 900;
			_graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Create the three trees
            treeRed = new Tree();
			treeGreen = new Tree();
			treeBlue = new Tree();

			// *** FILL EACH TREE WITH DATA HERE ***************************

			for (int i = 0; i < 1000; i++)
			{
				treeRed.Insert(rng.Next());
				treeGreen.Insert(i);
				treeBlue.Insert(rng.Next(100));
			}

			// *************************************************************
		}

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

			// *************************************************************
			// ************ OPTIONAL CHALLENGE: Remove data ****************
			//
			// Randomly (or not so randomly) attempt to remove one
			// piece of data from one or more trees each frame.
			//
			// Note: Due to the random generation of the values in the
			// trees, it's okay if some frames no values are removed.
			//
			// *************************************************************

			treeBlue.Remove(rng.Next(100));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

			ShapeBatch.Begin(GraphicsDevice);

			DrawTree(treeRed.Root, new Vector2(200, 200), Color.Red);
			DrawTree(treeGreen.Root, new Vector2(700, 200), Color.Green);
			DrawTree(treeBlue.Root, new Vector2(1200, 200), Color.DodgerBlue);

			ShapeBatch.End();

            base.Draw(gameTime);
        }


		private void DrawTree(TreeNode node, Vector2 position, Color color, float angle = 0)
		{
			// Ensure we don't try to use a null node
			if (node == null)
				return;

			// Need to draw left?
			if (node.Left != null)
			{
				// Calculate the angle and position of the left node
				float leftAngle = angle + BranchAngle;
				Vector2 leftPos = position - Vector2.TransformNormal(Vector2.UnitY * -BranchLength, Matrix.CreateRotationZ(leftAngle));

				// Recursively draw
				ShapeBatch.Line(position, leftPos, BranchWidth, color);
				DrawTree(node.Left, leftPos, color, leftAngle);
			}

			// Need to draw right?
			if (node.Right != null)
			{
				// Calculate the angle and position of the right node
				float rightAngle = angle - BranchAngle;
				Vector2 rightPos = position - Vector2.TransformNormal(Vector2.UnitY * -BranchLength, Matrix.CreateRotationZ(rightAngle));

				// Recursively draw
				ShapeBatch.Line(position, rightPos, BranchWidth, color);
				DrawTree(node.Right, rightPos, color, rightAngle);
			}
		}
    }
}
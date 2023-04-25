using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Note___Scaling_Using_Rectangles_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont title;
        private int score = 0;
        // This first variable will store our font for drawing. The second variable, score will give us a value to draw to the screen.

        Texture2D rectangleTexture, circleTexture;
        Rectangle circleRect, faceCirc, mouthRect, leftEyeCirc, rightEyeCirc;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 1000;
            circleRect = new Rectangle(100, 100, 40, 40);
            faceCirc = new Rectangle(250, 10, 500, 500);
            mouthRect = new Rectangle(360, 350, 300, 40);
            leftEyeCirc = new Rectangle(360, 75, 100, 100);
            rightEyeCirc = new Rectangle(600, 75, 100, 100);

            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");
            title = Content.Load<SpriteFont>("File.spritefont"); 
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // HOW TO USE RECTANGLES // // // // //
            _spriteBatch.Begin();
            ////                                      Rectangle is defined by 4 values: x & y of the top right corner, and the dimensions.
            ////                                      These are the numbers in the brackets after rectangle in the next line
            //_spriteBatch.Draw(rectangleTexture, new Rectangle(100, 100, 40, 40), Color.White);
            ////                                      i.e. the rectangle's top left corner will be drawn at (100, 100) and its dimensions will be 40x40

            //_spriteBatch.Draw(circleTexture, new Rectangle(100, 300, 40, 60), Color.Red);

            // PICTURE DRAWING // // // // // // //
            _spriteBatch.Draw(circleTexture, faceCirc, Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, mouthRect, Color.Black);
            _spriteBatch.Draw(circleTexture, leftEyeCirc, Color.Black);
            _spriteBatch.Draw(circleTexture, rightEyeCirc, Color.Black);

            _spriteBatch.DrawString(title, "score", new Vector2(100, 100), Color.Black);

            //_spriteBatch.Draw(circleTexture, circleRect, Color.Red);


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
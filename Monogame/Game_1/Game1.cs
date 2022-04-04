using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D normalTexture;
        private Texture2D jumpingTexture;
        private Vector2 position;
        private Vector2 speed;
        private bool isJumping;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            position = new Vector2(300, 200);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            position += speed;
            if (position.Y > 200)
            {
                position = new Vector2(position.X, 200);
                speed = Vector2.Zero;
                isJumping = false;
            }

            speed += new Vector2(0, 0.3f);

            var state = Keyboard.GetState();
            if(state.IsKeyDown(Keys.W) && !isJumping)
            {
                speed = new Vector2(0, -5.0f);
                isJumping = true;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            if (isJumping)
            {
                spriteBatch.Draw(jumpingTexture, position, Color.White);   
            }
            else
            {
                spriteBatch.Draw(normalTexture, position, Color.White); 
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

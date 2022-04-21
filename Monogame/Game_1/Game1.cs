using System.Collections.Generic;
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
        private Texture2D crouchTexture;
        private Texture2D fireballTexture;

        private List<Vector2> fireballs;
        
        private int fireballTimer = 120;
        private Vector2 position;
        private Vector2 speed;
        private bool isJumping;
        private bool isCrouching;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            position = new Vector2(300, 200);
            fireballs = new List<Vector2>();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            normalTexture = Content.Load<Texture2D>("normal");
            jumpingTexture = Content.Load<Texture2D>("jump");
            crouchTexture = Content.Load<Texture2D>("crouch");
            fireballTexture = Content.Load<Texture2D>("fireball");
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
            if(state.IsKeyDown(Keys.S) && !isJumping)
            {
                isCrouching = true;
            }
            else
            {
                isCrouching = false;
            }

            //fireballs
            fireballTimer--;
            if (fireballTimer <=0)
            {
                fireballTimer = 120;
                fireballs.Add(new Vector2(700, 210));
            }
            for (int i = 0; i < fireballs.Count; i++)
            {
                fireballs[i] = fireballs[i] + new Vector2(-1, 0);
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
            else if(isCrouching)
            {
                spriteBatch.Draw(crouchTexture, position, Color.White); 
            }
            else
            {
                spriteBatch.Draw(normalTexture, position, Color.White); 
            }

            foreach (var fireball in fireballs)
            {
                spriteBatch.Draw(fireballTexture, fireball, Color.White);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace InTime
{
    class BackGround
    {
        Texture2D texture;
        Texture2D collisionmap;
        Vector2 position;
        public void load()
        {
            position = Vector2.Zero;
        }
        public void Draw(GameTime gameTime, GraphicsDeviceManager graphics, SpriteBatch spriteBatch)
        {
        }
        public void Update(GameTime gameTime)
        {
        }
    }
}

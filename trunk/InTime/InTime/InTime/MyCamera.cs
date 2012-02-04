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
    class MyCamera
    {
            Vector2 position;
            float scale;
            float rotation;
            public void Move(Vector2 offset){
                position += offset;
            }
            public MyCamera()
            {
                position = Vector2.Zero;
                scale = 1;
                rotation = 0;
            }
    };
}

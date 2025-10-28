using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RainyDaze
{
    internal class Sprite
    {
        public Texture2D Texture { get; }
        public Vector2 Position { get; set; }

        public Sprite(Texture2D texture, Vector2 startPosition)
        {
            Texture = texture;
            Position = startPosition;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
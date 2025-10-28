using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RainyDaze
{
    internal class Player
    {
        private readonly Sprite _sprite;
        private readonly PlayerMovement _movement;

        public Player(Texture2D texture, Vector2 startPosition, float speed)
        {
            _sprite = new Sprite(texture, startPosition);
            _movement = new PlayerMovement(speed);
        }

        public void Update(GameTime gameTime)
        {
            _sprite.Position = _movement.Update(_sprite.Position);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch);
        }
    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace RainyDaze
{
    internal class PlayerMovement
    {
        private readonly float _speed;

        public PlayerMovement(float speed)
        {
            _speed = speed;
        }

        public Vector2 Update(Vector2 currentPosition)
        {
            var keyboard = Keyboard.GetState();

            if (keyboard.IsKeyDown(Keys.Right))
                currentPosition.X += _speed;
            if (keyboard.IsKeyDown(Keys.Left))
                currentPosition.X -= _speed;
            if (keyboard.IsKeyDown(Keys.Up))
                currentPosition.Y -= _speed;
            if (keyboard.IsKeyDown(Keys.Down))
                currentPosition.Y += _speed;

            return currentPosition;
        }
    }
}
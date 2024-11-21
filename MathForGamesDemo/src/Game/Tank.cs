using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;

namespace MathForGamesDemo
{
    internal class Tank : Actor
    {
        public static int CollisionCount = 0;
        public float Speed { get; set; } = 50;
        public float RotationSpeed { get; set; } = 2f; // Radians per second
        private Color _color = Color.Blue;

        private float rotation = 0f; // Rotation in radians
        private Vector2 movementInput = new Vector2();
        private int _collisionCount;
        

        public override void Update(double deltaTime)
        {
            // Call base Update
            base.Update(deltaTime);

            // rotation 
            if (Raylib.IsKeyDown(KeyboardKey.A))
                rotation -= RotationSpeed * (float)deltaTime; // Rotate counterclockwise

            if (Raylib.IsKeyDown(KeyboardKey.D))
                rotation += RotationSpeed * (float)deltaTime; // Rotate clockwise

            // forward vector from rotation
            Vector2 forward = new Vector2(
                MathF.Cos(rotation),
                MathF.Sin(rotation)
            );

            // reset movement input
            movementInput = new Vector2();

            // forward/backward 
            if (Raylib.IsKeyDown(KeyboardKey.W))
                movementInput += forward; // Move forward

            if (Raylib.IsKeyDown(KeyboardKey.S))
                movementInput -= forward; // Move backward

            //  delta movement
            Vector2 deltaMovement = movementInput * Speed * (float)deltaTime;

            // Update the tank's position
            Transform.LocalPosition += deltaMovement;



            // fwd vector
            Raylib.DrawLineV(
                Transform.GlobalPosition,
                Transform.GlobalPosition + forward * 20, // Scale forward vector for visualization
                Color.Red
            );

          
                
           

            // Display collision count
            Raylib.DrawText($"Points count: {CollisionCount}", 10, 60, 20, Color.White);
        }

        public override void OnCollision(Actor other)
        {
            if (other != null)
            {
                
                _collisionCount++;
                _color = Color.Gold;
                
            }
        }
    }
}
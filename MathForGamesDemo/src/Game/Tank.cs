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

            // Handle rotation input
            if (Raylib.IsKeyDown(KeyboardKey.A))
                rotation -= RotationSpeed * (float)deltaTime; // Rotate counterclockwise

            if (Raylib.IsKeyDown(KeyboardKey.D))
                rotation += RotationSpeed * (float)deltaTime; // Rotate clockwise

            // Calculate the forward vector from rotation
            Vector2 forward = new Vector2(
                MathF.Cos(rotation),
                MathF.Sin(rotation)
            );

            // Reset movement input
            movementInput = new Vector2();

            // Handle forward/backward movement
            if (Raylib.IsKeyDown(KeyboardKey.W))
                movementInput += forward; // Move forward

            if (Raylib.IsKeyDown(KeyboardKey.S))
                movementInput -= forward; // Move backward

            // Calculate delta movement
            Vector2 deltaMovement = movementInput * Speed * (float)deltaTime;

            // Update the tank's position
            Transform.LocalPosition += deltaMovement;

            // Call base Update
            base.Update(deltaTime);


            // Debug visualization
            Raylib.DrawLineV(
                Transform.GlobalPosition,
                Transform.GlobalPosition + forward * 20, // Scale forward vector for visualization
                Color.Red
            );

            // Draw the tank (simplified rectangle for visualization)
           //   Raylib.DrawTextureV(texture, movementInput, Color.Green);
                 // Size of the tank
                
           

            // Display collision count
            Raylib.DrawText($"Collision Count: {CollisionCount}", 10, 60, 20, Color.White);
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
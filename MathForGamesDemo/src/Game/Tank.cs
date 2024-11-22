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
        public static int collisionCount = 0;
        private int _speed = 200;

        private float _rotationSpeed  = 2f; 

        private Color _color = Color.Blue;

        private float rotation = 0f; // rotation in rads
        private Vector2 movementInput = new Vector2();

        private int _collisionCount;
        
                

        public override void Update(double deltaTime)
        {
            // Call base Update
            base.Update(deltaTime);

            // rotation 
            if (Raylib.IsKeyDown(KeyboardKey.A))
            {

                rotation -= _rotationSpeed * (float)deltaTime; // rotate counterclockwise

            }    

            if (Raylib.IsKeyDown(KeyboardKey.D))
            {

                rotation += _rotationSpeed * (float)deltaTime; // rotate clockwise

            }

            // forward vector from rotation
            Vector2 forward = new Vector2(MathF.Cos(rotation), MathF.Sin(rotation));



            // reset movement input
            movementInput = new Vector2();

            // forward/backward 
            if (Raylib.IsKeyDown(KeyboardKey.W))
            {

                movementInput += forward; // Move forward

            }


            if (Raylib.IsKeyDown(KeyboardKey.S))
            {

                movementInput -= forward; // Move backward

            }


            //  delta movement
            Vector2 deltaMovement = movementInput * _speed * (float)deltaTime;


           
            Transform.LocalPosition += deltaMovement;


            /*
            // fwd vector
            Raylib.DrawLineV(
                Transform.GlobalPosition,
                Transform.GlobalPosition + forward * 20, 
                Color.Red
            );
            */
          
                
           

            // Display collision count
            Raylib.DrawText($"Baby Oil Bottles: {collisionCount}", 10, 60, 20, Color.White);

            if (collisionCount >= 12)
            {
                Raylib.CloseWindow();
            }
        }

        public override void OnCollision(Actor other)
        {
                
                _collisionCount++;
                _color = Color.Gold;
                
            
        }
    }
}
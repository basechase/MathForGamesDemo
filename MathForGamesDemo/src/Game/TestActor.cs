using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;


 
namespace MathForGamesDemo
{
    internal class TestActor : Actor
    {
        public float Speed { get; set; } = 50;

       private Color _color = Color.White;

       private Vector2 movementInput = new Vector2();

        public override void Update(double deltaTime)
        {
           Vector2 deltaMovement = movementInput.Normalized * Speed * (float)deltaTime;
            base.Update(deltaTime);

          
          

            //movement
            if (Raylib.IsKeyPressed(KeyboardKey.Up))
                movementInput.y -= Speed; // Adjusted to constant input for normalization

            if (Raylib.IsKeyPressed(KeyboardKey.Down))
                movementInput.y += Speed;




            if (deltaMovement.Magnitude != 0)
            {
                Transform.LocalPosition += (deltaMovement);
            }
            Raylib.DrawRectangleV(Transform.GlobalPosition + new Vector2(0,50), Transform.GlobalScale *-100, Color.Blue);


        }



        public override void OnCollision(Actor other)
        {
            
            
        }

    }
}

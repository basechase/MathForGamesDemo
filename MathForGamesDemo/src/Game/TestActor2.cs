using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathForGamesDemo;
using MathLibrary;
using Raylib_cs;

namespace MathForGamesDemo
{
    internal class TestActor2 : Actor
    {
        public float Speed { get; set; } = 50;

        private Color _color = Color.White;

        private Vector2 movementInput = new Vector2();

        public override void Update(double deltaTime)
        {
            Vector2 deltaMovement = movementInput.Normalized * Speed * (float)deltaTime;
            base.Update(deltaTime);




          




            if (deltaMovement.Magnitude != 0)
            {
                Transform.LocalPosition += (deltaMovement);
            }
            Raylib.DrawRectangleV(Transform.GlobalPosition + new Vector2(100, 50), Transform.GlobalScale * -100, _color);


        }



        public override void OnCollision(Actor other)
        {
            Tank.CollisionCount++;
            Actor.Destroy(this);

        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;


namespace MathForGamesDemo
{
    namespace MathForGamesDemo
    {
        internal class Ball : Actor
        {
            // deja was here 
            public float Speed { get; set; } = 10;

            private Color _color = Color.White;

            public Vector2 _ballVelocity = new Vector2(0.07f, 0.07f);
            private Vector2 _ballPos = new Vector2(200, 140);





            public override void Update(double deltaTime)
            {
                // Vector2 deltaMovement = movementInput.Normalized * Speed * (float)deltaTime;
                base.Update(deltaTime);
                _ballPos += _ballVelocity;
                Raylib.DrawCircleV(_ballPos, 5, Color.Pink);


                //collides with bottom/top of screen
                if (_ballPos.y <= 0 || _ballPos.y >= Raylib.GetScreenHeight())
                {
                    _ballVelocity.y = -_ballVelocity.y;
                }


                //movement



                /* if (deltaMovement.Magnitude != 0)
                 *{
                 *   Transform.LocalPosition += (deltaMovement);
                 *}
                 *Raylib.DrawRectangleV(Transform.GlobalPosition, Transform.GlobalScale * 100, Color.Blue);
                 */

            }



            public override void OnCollision(Actor other)
            {





            }

        }
    }

}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;



namespace MathForGamesDemo
{
    internal class TestActor : Actor
    {
        public float Speed { get; set; } = 50;

       
        public override void Update(double deltaTime)
        {
            base.Update(deltaTime);
            
            Vector2 movementInput = new Vector2();
            movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
            movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
            movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
            movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);


            Vector2 deltamovement = movementInput.Normalized * Speed * (float)deltaTime;

            if (deltamovement.Magnitude != 0)
            {
                Transform.LocalPosition += (deltamovement);
            }
            Raylib.DrawRectangleV(Transform.GlobalPosition, Transform.GlobalScale * 100, Color.Blue);

        }


      
        

    }
}

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

        private Color _color = Color.Red;

        private Vector2 movementInput = new Vector2();

        public override void Update(double deltaTime)
        {
           Vector2 toPlayer = new Vector2();
            base.Update(deltaTime);
            



          




            
            


        }



        public override void OnCollision(Actor other)
        {
            Raylib.CloseWindow();

        }

    }
}

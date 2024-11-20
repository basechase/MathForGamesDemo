using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MathForGamesDemo.MathForGamesDemo;
using MathLibrary;
using Raylib_cs;

namespace MathForGamesDemo
{

    internal class TestScene : Scene
    {
    Actor _paddle1;
    Actor _paddle2;
        Actor _ball;

        public override void Start()
        {
            base.Start();

            // add our cool actor
            Actor _paddle1 = new TestActor();
            _paddle1.Transform.LocalPosition = new Vector2(700,50);
            AddActor(_paddle1);

            Actor _ball = new Ball();
            _ball.Transform.LocalPosition = new Vector2(400, 500);
            AddActor(_ball);


            //paddle 2
            Actor _paddle2 = new TestActor2();
            _paddle2.Transform.LocalPosition = new Vector2(100, 50);
            AddActor(_paddle2);


            _paddle1.Collider = new CircleCollider(_paddle1, 50);

            _paddle2.Collider = new CircleCollider(_paddle2, 50);
            _ball.Collider = new CircleCollider(_ball, 50);



            _ball = Actor.Instantiate(new Actor("ball"), null, new Vector2(700, 50), 0);
            _paddle2 = Actor.Instantiate(new Actor("paddle 2"), null, new Vector2(700, 50), 0);
            _paddle1 = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 50), 0);
            

           
                

            



          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

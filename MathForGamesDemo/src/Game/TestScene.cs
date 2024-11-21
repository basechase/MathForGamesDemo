using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MathForGamesDemo;
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
            
            _paddle1.Transform.LocalPosition = new Vector2(700,500);
            AddActor(_paddle1);

            

            Actor _tank = new Tank();
            _tank.Transform.LocalPosition = new Vector2(300, 500);
            _tank.AddComponent(new SpriteComponent(_tank, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\kanye.png"));
            AddActor(_tank);

            //paddle 2
            Actor _paddle2 = new TestActor2();
            _paddle2.Transform.LocalPosition = new Vector2(700, 300);
            _paddle2.AddComponent(new SpriteComponent(_paddle2, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\twix_bar_black.png"));
            AddActor(_paddle2);




            _paddle1.Collider = new CircleCollider(_paddle1, 50);

            _paddle2.Collider = new CircleCollider(_paddle2, 50);

            _tank.Collider = new CircleCollider(_tank, 20);

            _tank = Actor.Instantiate(new Actor("tank"), null, new Vector2(300,500));
            
            _paddle2 = Actor.Instantiate(new Actor("paddle 2"), null, new Vector2(700, 00), 0);
            _paddle1 = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 500), 0);

            
           


            
                

            



          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

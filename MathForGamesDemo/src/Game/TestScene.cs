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
    Actor _twix1;
    Actor thing;
    Actor _tank;
       

        public override void Start()
        {
            base.Start();

            Actor _yeezy = new TestActor2();
            _yeezy.Transform.LocalPosition = new Vector2 (200,200);
            _yeezy.AddComponent(new SpriteComponent(_yeezy, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\yeezy.png"));
            AddActor(_yeezy);
                       



            Actor _twix1 = new TestActor();
            _twix1.Transform.LocalPosition = new Vector2(500,400);
            _twix1.AddComponent(new SpriteComponent(_twix1, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\file.png"));
            AddActor(_twix1);

            Actor thing = new TestActor();
            thing.Transform.LocalPosition = new Vector2(700, 300);
            thing.AddComponent(new SpriteComponent(thing, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\glep.png"));
            AddActor(thing);

            Actor _tank = new Tank();
            _tank.Transform.LocalPosition = new Vector2(300, 500);
            _tank.AddComponent(new SpriteComponent(_tank, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\kanye.png"));
            AddActor(_tank);



            _yeezy.Collider = new CircleCollider(_yeezy, 20);
            thing.Collider = new CircleCollider(thing, 50);

            _twix1.Collider = new CircleCollider(_twix1, 50);

       

            _tank.Collider = new CircleCollider(_tank, 20);

            _yeezy = Actor.Instantiate(new Actor("yeezy"), null, new Vector2(200,200));
            _tank = Actor.Instantiate(new Actor("tank"), null, new Vector2(300,500));
            thing = Actor.Instantiate(new Actor("thing"), null, new Vector2(700, 300));
           
            _twix1 = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 500), 0);

            
           


            
                

            



          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

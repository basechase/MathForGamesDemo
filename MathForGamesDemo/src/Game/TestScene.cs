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
        Actor _twix2;
        Actor _twix3;
        Actor _twix4;
        Actor _twix5;
        Actor _twix6;
        Actor _twix7;
        Actor _twix8;
        Actor _twix9;
        Actor _twix10;
        Actor _twix11;
        Actor _twix12;

        Actor thing;

        Actor _tank;

        Actor _tape1;
        Actor _tape2;
        Actor _tape3;
        Actor _tape4;
        Actor _tape5;   

        public override void Start()
        {
            base.Start();


            Actor _tape1 = new TestActor2();
            Actor _tape2 = new TestActor2();
            Actor _tape3 = new TestActor2();
            Actor _tape4 = new TestActor2();
            Actor _tape5 = new TestActor2();



            Actor _twix1 = new TestActor();
            Actor _twix2 = new TestActor();
            Actor _twix3 = new TestActor();
            Actor _twix4 = new TestActor();
            Actor _twix5 = new TestActor();
            Actor _twix6 = new TestActor();
            Actor _twix7 = new TestActor();
            Actor _twix8= new TestActor();
            Actor _twix9 = new TestActor();
            Actor _twix10 = new TestActor();
            Actor _twix11= new TestActor();
            Actor _twix12 = new TestActor();



            
            _tape1.Transform.LocalPosition = new Vector2 (200,200);
            _tape1.AddComponent(new SpriteComponent(_tape1, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\tape.png"));
            AddActor(_tape1);


            _tape2.Transform.LocalPosition = new Vector2(400, 200);
            _tape2.AddComponent(new SpriteComponent(_tape2, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\tape.png"));
            AddActor(_tape2);

            _tape3.Transform.LocalPosition = new Vector2(600, 200);
            _tape3.AddComponent(new SpriteComponent(_tape3, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\tape.png"));
            AddActor(_tape3);


            _tape4.Transform.LocalPosition = new Vector2(800, 200);
            _tape4.AddComponent(new SpriteComponent(_tape4, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\tape.png"));
            AddActor(_tape4);

            _tape5.Transform.LocalPosition = new Vector2(600, 400);
            _tape5.AddComponent(new SpriteComponent(_tape5, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\tape.png"));
            AddActor(_tape5);






            _twix1.Transform.LocalPosition = new Vector2(100, 100);
            _twix1.AddComponent(new SpriteComponent(_twix1, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix1);

            _twix2.Transform.LocalPosition = new Vector2(300, 100);
            _twix2.AddComponent(new SpriteComponent(_twix2, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix2);

            _twix3.Transform.LocalPosition = new Vector2(500, 100);
            _twix3.AddComponent(new SpriteComponent(_twix3, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix3);

            _twix4.Transform.LocalPosition = new Vector2(700, 100);
            _twix4.AddComponent(new SpriteComponent(_twix4, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix4);

            _twix5.Transform.LocalPosition = new Vector2(100, 300);
            _twix5.AddComponent(new SpriteComponent(_twix5, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix5);

            _twix6.Transform.LocalPosition = new Vector2(300, 300);
            _twix6.AddComponent(new SpriteComponent(_twix6, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix6);

            _twix7.Transform.LocalPosition = new Vector2(500, 300);
            _twix7.AddComponent(new SpriteComponent(_twix7, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix7);

            _twix8.Transform.LocalPosition = new Vector2(700, 300);
            _twix8.AddComponent(new SpriteComponent(_twix8, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix8);

            _twix9.Transform.LocalPosition = new Vector2(100, 500);
            _twix9.AddComponent(new SpriteComponent(_twix9, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix9);

            _twix10.Transform.LocalPosition = new Vector2(300, 500);
            _twix10.AddComponent(new SpriteComponent(_twix10, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix10);

            _twix11.Transform.LocalPosition = new Vector2(500, 500);
            _twix11.AddComponent(new SpriteComponent(_twix11, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix11);

            _twix12.Transform.LocalPosition = new Vector2(700, 500);
            _twix12.AddComponent(new SpriteComponent(_twix12, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_twix12);







            Actor thing = new TestActor();
            thing.Transform.LocalPosition = new Vector2(700, 800);
            thing.AddComponent(new SpriteComponent(thing, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\glep.png"));
            AddActor(thing);

            Actor _tank = new Tank();
            _tank.Transform.LocalPosition = new Vector2(1100, 800);
            _tank.AddComponent(new SpriteComponent(_tank, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\diddy.png"));
            AddActor(_tank);








            //colliders




            _twix1.Collider = new CircleCollider(_twix1, 50);
            _twix2.Collider = new CircleCollider(_twix2, 50);
            _twix3.Collider = new CircleCollider(_twix3, 50);
            _twix4.Collider = new CircleCollider(_twix4, 50);
            _twix5.Collider = new CircleCollider(_twix5, 50);
            _twix6.Collider = new CircleCollider(_twix6, 50);
            _twix7.Collider = new CircleCollider(_twix7, 50);
            _twix8.Collider = new CircleCollider(_twix8, 50);
            _twix9.Collider = new CircleCollider(_twix9, 50);
            _twix10.Collider = new CircleCollider(_twix10, 50);
            _twix11.Collider = new CircleCollider(_twix11, 50);
            _twix12.Collider = new CircleCollider(_twix12, 50);




            _tape1.Collider = new CircleCollider(_tape1, 20);
            _tape2.Collider = new CircleCollider(_tape2, 20);
            _tape3.Collider = new CircleCollider(_tape3, 20);
            _tape4.Collider = new CircleCollider(_tape4, 20);
            _tape5.Collider = new CircleCollider(_tape5, 20);
            //glep
            thing.Collider = new CircleCollider(thing, 50);


       

            _tank.Collider = new CircleCollider(_tank, 25);

            
           


            
                

            //instantiate actors
            _tape1 = Actor.Instantiate(new Actor("yeezy"), null, new Vector2(200,200));
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

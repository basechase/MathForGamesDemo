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
    
       

        public override void Start()
        {
            base.Start();


            Actor _tape1 = new TestActor2();
            Actor _tape2 = new TestActor2();
            Actor _tape3 = new TestActor2();
            Actor _tape4 = new TestActor2();
            Actor _tape5 = new TestActor2();



            Actor _babyOil1 = new TestActor();
            Actor _babyOil2 = new TestActor();
            Actor _babyOil3 = new TestActor();
            Actor _babyOil4 = new TestActor();
            Actor _babyOil5 = new TestActor();
            Actor _babyOil6 = new TestActor();
            Actor _babyOil7 = new TestActor();
            Actor _babyOil8= new TestActor();
            Actor _babyOil9 = new TestActor();
            Actor _babyOil10 = new TestActor();
            Actor _babyOil11= new TestActor();
            Actor _babyOil12 = new TestActor();



            
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






            _babyOil1.Transform.LocalPosition = new Vector2(100, 100);
            _babyOil1.AddComponent(new SpriteComponent(_babyOil1, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil1);

            _babyOil2.Transform.LocalPosition = new Vector2(300, 100);
            _babyOil2.AddComponent(new SpriteComponent(_babyOil2, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil2);

            _babyOil3.Transform.LocalPosition = new Vector2(500, 100);
            _babyOil3.AddComponent(new SpriteComponent(_babyOil3, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil3);

            _babyOil4.Transform.LocalPosition = new Vector2(700, 100);
            _babyOil4.AddComponent(new SpriteComponent(_babyOil4, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil4);

            _babyOil5.Transform.LocalPosition = new Vector2(100, 300);
            _babyOil5.AddComponent(new SpriteComponent(_babyOil5, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil5);

            _babyOil6.Transform.LocalPosition = new Vector2(300, 300);
            _babyOil6.AddComponent(new SpriteComponent(_babyOil6, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil6);

            _babyOil7.Transform.LocalPosition = new Vector2(500, 300);
            _babyOil7.AddComponent(new SpriteComponent(_babyOil7, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil7);

            _babyOil8.Transform.LocalPosition = new Vector2(700, 300);
            _babyOil8.AddComponent(new SpriteComponent(_babyOil8, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil8);

            _babyOil9.Transform.LocalPosition = new Vector2(100, 500);
            _babyOil9.AddComponent(new SpriteComponent(_babyOil9, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil9);

            _babyOil10.Transform.LocalPosition = new Vector2(300, 500);
            _babyOil10.AddComponent(new SpriteComponent(_babyOil10, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil10);

            _babyOil11.Transform.LocalPosition = new Vector2(500, 500);
            _babyOil11.AddComponent(new SpriteComponent(_babyOil11, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil11);

            _babyOil12.Transform.LocalPosition = new Vector2(700, 500);
            _babyOil12.AddComponent(new SpriteComponent(_babyOil12, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\baby_oil_small.png"));
            AddActor(_babyOil12);







            Actor thing = new TestActor();
            thing.Transform.LocalPosition = new Vector2(700, 800);
            thing.AddComponent(new SpriteComponent(thing, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\glep.png"));
            AddActor(thing);

            Actor _tank = new Tank();
            _tank.Transform.LocalPosition = new Vector2(1100, 800);
            _tank.AddComponent(new SpriteComponent(_tank, "C:\\dev\\MathForGamesDemo\\MathForGamesDemo\\src\\images\\diddy.png"));
            AddActor(_tank);








            //colliders




            _babyOil1.Collider = new CircleCollider(_babyOil1, 50);
            _babyOil2.Collider = new CircleCollider(_babyOil2, 50);
            _babyOil3.Collider = new CircleCollider(_babyOil3, 50);
            _babyOil4.Collider = new CircleCollider(_babyOil4, 50);
            _babyOil5.Collider = new CircleCollider(_babyOil5, 50);
            _babyOil6.Collider = new CircleCollider(_babyOil6, 50);
            _babyOil7.Collider = new CircleCollider(_babyOil7, 50);
            _babyOil8.Collider = new CircleCollider(_babyOil8, 50);
            _babyOil9.Collider = new CircleCollider(_babyOil9, 50);
            _babyOil10.Collider = new CircleCollider(_babyOil10, 50);
            _babyOil11.Collider = new CircleCollider(_babyOil11, 50);
            _babyOil12.Collider = new CircleCollider(_babyOil12, 50);




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
           
            _babyOil1 = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 500), 0);




          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

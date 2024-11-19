using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;
using Raylib_cs;

namespace MathForGamesDemo
{

    internal class TestScene : Scene
    {
    Actor _theBoi;
    Actor _paddle2;


        public override void Start()
        {
            base.Start();

            // add our cool actor
            Actor actor = new TestActor();
            actor.Transform.LocalPosition = new Vector2(700,50);
            AddActor(actor);



            //paddle 2
            Actor paddle2 = new TestActor2();
            paddle2.Transform.LocalPosition = new Vector2(100, 50);
            AddActor(paddle2);


            paddle2.Collider = new CircleCollider(paddle2, 50);

            actor.Collider = new CircleCollider(actor, 50);
            

            


            paddle2 = Actor.Instantiate(new Actor("paddle 2"), null, new Vector2(700, 50), 0);
            _theBoi = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 50), 0);
            

           
                

            



          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

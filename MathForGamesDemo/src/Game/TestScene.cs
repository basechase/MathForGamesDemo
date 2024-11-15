using System;
using System.Collections.Generic;
using System.Linq;
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
            actor.Transform.LocalPosition = new Vector2(300,100);
            AddActor(actor);



            //paddle 2


            Actor paddle2 = new TestActor();
            paddle2.Transform.LocalPosition = new Vector2(750 , 100);
            AddActor(paddle2);


            actor.Collider = new CircleCollider(actor, 50);


            _paddle2 = Actor.Instantiate(new Actor("paddle2"), null, new Vector2( 750,100 ), 0);



            _theBoi = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 300), 0);
            _theBoi.Collider = new CircleCollider(_theBoi, 50);

           
                

            



          



            
         
            

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            
        }

    }
}

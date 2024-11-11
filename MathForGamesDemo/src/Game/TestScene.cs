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


        public override void Start()
        {
            base.Start();

            // add our cool actor
            Actor actor = new TestActor();
            actor.Transform.LocalPosition = new Vector2(300,100);
            AddActor(actor);
            actor.Collider = new CircleCollider(actor, 50);




            _theBoi = Actor.Instantiate(new Actor("circle 1"), null, new Vector2(300, 300), 0);
            _theBoi.Collider = new CircleCollider(_theBoi, 50);

           
                

            

            Component comp1 = _theBoi.AddComponent(new SpriteComponent(_theBoi, "1"));
            Component comp2 = _theBoi.AddComponent(new SpriteComponent(_theBoi, "2"));
            Component comp3 = _theBoi.AddComponent(new SpriteComponent(_theBoi, "3"));
            Component comp4 = _theBoi.AddComponent(new SpriteComponent(_theBoi, "4"));



            _theBoi.RemoveComponent(comp1);
            _theBoi.RemoveComponent(comp2);
            _theBoi.RemoveComponent(comp3);
            _theBoi.RemoveComponent(comp4);

       

        }


        public override void Update(double deltaTime)
        {
            
            base.Update(deltaTime);
            Raylib.DrawCircleV(_theBoi.Transform.GlobalPosition, 50, Color.Black);
        }

    }
}

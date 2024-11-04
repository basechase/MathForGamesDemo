using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MathForGamesDemo
{
    internal class CircleCollider : Collider
    {



        public float CollisioRadius {  get; set; }
        public CircleCollider(Actor owner, float radius) : base(owner)
        {
            CollisioRadius = radius;
        }




        public override bool CheckCollisionCircle(CircleCollider collider)
        {
            float sunRadii = collider.CollisioRadius + CollisioRadius;
            float distance = Vector2.Distance(collider.Owner.Transform.GlobalPosition, Owner.Transform.GlobalPosition);
            

            return sunRadii >= distance;
        }

        public override void Draw()
        {
            base.Draw();
            Raylib.DrawCircleLinesV(Owner.Transform.GlobalPosition, CollisioRadius, Color.Green);
        }

    }
}
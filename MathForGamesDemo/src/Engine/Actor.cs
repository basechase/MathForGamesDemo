using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MathForGamesDemo
{
    internal class Actor
    {



        private bool _started = false;
        private bool _enabled = true;

        private Component[] _components;

        public bool Enabled
        {
            get => _enabled;
            set
            {
                if (_enabled == value) return;
                {
                    _enabled = value;
                    // if value is true, call Onenabled
                    if (_enabled)
                    {

                        OnEnable();
                    }


                    // if value is false, call Ondisabled
                    else
                    {
                        OnDisable();
                    }

                }
            }     
            
        }     



        public Collider Collider { get;  set; }

        public bool Started { get => _started; }

        public string Name { get; set; }


        public Transform2D Transform { get; protected set; }

        public Actor(string name = "Actor")
        {
            Name = name;
            Transform = new Transform2D(this);
            _components = new Component[0]; 
        }

        public static Actor Instantiate(
            Actor actor,
            Transform2D parent = null,
            Vector2 position = new Vector2(),
            float rotation = 0,
            string name = "Actor")

        {



            // set actor transform values
            actor.Transform.LocalPosition = position;
            actor.Transform.Rotate(rotation);
            actor.Name = name;
            if (parent != null)
            {

                parent.AddChild(actor.Transform);

            }


            // add actor to the current scene
            Game.CurrentScene.AddActor(actor);

            return actor;
        }

        public static void Destroy (Actor actor)
        {
            //remove all children
            foreach (Transform2D child in actor.Transform.Children)
            {
                actor.Transform.RemoveChild(child);
            }
            //unchild from parent
            if (actor.Transform.Parent !=null)
            {
                actor.Transform.Parent.RemoveChild(actor.Transform);
            }



            Game.CurrentScene.RemoveActor(actor);
        }

        public virtual void OnEnable()
        {

        }

        public virtual void OnDisable()
        {

        }


        public virtual void Start()
        {
            _started = true;
            
        }


        public virtual void Update(double deltaTime)
        {
            
        }

        public virtual void End()
        {

        }
        public virtual void OnCollision(Actor other) 
        {
        
        }





        //add component

        //remove component

        //get component

        //get components
    }
}

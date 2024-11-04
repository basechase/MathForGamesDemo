﻿using System;
using System.Collections.Generic;
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
    }
}
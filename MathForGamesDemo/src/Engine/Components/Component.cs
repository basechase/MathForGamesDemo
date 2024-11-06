﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathForGamesDemo
{
    internal class Component
    {
        private Actor _owner;
        private bool _enabled;
        private bool _started;
        public Actor Own { get =>_owner;  }
        
        public bool Enabled
        {
            get => _enabled;
            set
            {
                //if enabled would not change. do nothing
                if (_enabled == value) return;
                { 
                _enabled = value;
                }
                if (_enabled)
                {
                    OnEnable();
                }
                else
                {
                    OnDisable();
                }

            }
        }

        public bool Started { get => _started; }
        public Component(Actor owner)
        {
            _enabled = true;
            _started = false;
            _owner = owner; 
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


    }
}

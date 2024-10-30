using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathForGamesDemo
{
    internal class Scene
    {
        private List<Actor> _actors;

        private static Scene _currentScene;

        public static Scene CurrentScene { get => _currentScene; }



        public void AddActor(Actor actor)
        {
            if (!_actors.Contains(actor))
            { 
            _actors.Add(actor);
            }
            
        }



        public bool RemoveActor(Actor actor)
        {
            return _actors.Remove(actor);
        }

        public virtual void Start()
        {
            if(_currentScene == null)
            {
                _currentScene = this;
                
            }

            _actors = new List<Actor>();    
        }


        public virtual void Update(double deltaTime)
        {

            //Update actors
            foreach(Actor actor in _actors)
            {
                if (!actor.Started)
                    actor.Start();

                actor.Update(deltaTime);
            }

        }


        public virtual void End()
        {
            foreach(Actor actor in _actors)
            {
                actor.End();
            }
        }

    }
}

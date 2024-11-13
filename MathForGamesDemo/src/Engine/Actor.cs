using MathForGamesDemo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace MathForGamesDemo
{
    internal class Actor
    {



        private bool _started = false;
        private bool _enabled = true;

        private Component[] _components;
        private Component[] _componentsToRemove;



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



        public Collider Collider { get; set; }

        public bool Started { get => _started; }

        public string Name { get; set; }


        public Transform2D Transform { get; protected set; }

        public Actor(string name = "Actor")
        {
            Name = name;
            Transform = new Transform2D(this);
            _components = new Component[0];
            _componentsToRemove = new Component[0];
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

        public static void Destroy(Actor actor)
        {
            //remove all children
            foreach (Transform2D child in actor.Transform.Children)
            {
                actor.Transform.RemoveChild(child);
            }
            //unchild from parent
            if (actor.Transform.Parent != null)
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
            foreach (Component component in _components)
            {
                if (!component.Started)
                {
                    component.Start();
                }

                component.Update(deltaTime);
            }
            //remove components that should be removed
            RemoveComponentsToBeRemoved();

        }

        public virtual void End()
        {

            foreach (Component component in _components)
            {
                component.End();
            }
        }
        public virtual void OnCollision(Actor other)
        {

        }





        //add component
        public T AddComponent<T>(T component) where T : Component
        {
            //create temp array, one bigger than _components, need the extra slot

            Component[] temp = new Component[_components.Length + 1];

            //deep copy components into temp

            for (int i = 0; i < _components.Length; i++)
            {
                temp[i] = _components[i];
            }


            //set last index in temp to component we wish to add

            temp[temp.Length - 1] = component;

            //store tmep in _componenetss
            _components = temp;


            return component;
        }




        public T AddComponent<T>() where T : Component, new()
        {
            T component = (T)new Component(this);
            component.Owner = this;
            return AddComponent(component);
        }

        //remove component

        public bool RemoveComponent<T>(T component) where T : Component
        {

            //edge case for empty component array
            if (_components.Length <= 0)
            {
                return false;
            }

            if (_components.Length == 1 && _components[0] == component)
            {
                //add component to _componentsToRemove
                AddComponentToRemove(component);

                return true;
            }


            //loop through componenets
            foreach (Component comp in _components)
            {
                //if this component is the component we want to remove
                if (comp == component)
                {
                    //add component to _componentsToRemove

                    AddComponentToRemove(comp);
 

                    return true;
                }
            }
            return false;
            //    }
            //    //edge case for only one component
            //    if (_components.Length == 1 && _components[0] == component)
            //    {
            //        _components = new Component[0];
            //        return true;
            //    }
            //    //create temp array one smaller than _components
            //    Component[] temp = new Component[_components.Length - 1];
            //    bool componentRemoved = false;

            //    // deep copy _components into tempo minus the one componenet

            //    int j = 0;

            //    for (int i = 0; j < _components.Length - 1; i++)
            //    {
            //        if (_components[i] != component)
            //        {
            //            temp[j] = _components[i];
            //            j++;
            //        }
            //        else
            //        {
            //            componentRemoved = true;
            //        }
            //    }
            //    if (componentRemoved)
            //    {
            //        component.End();
            //        _components = temp;
            //    }
            //    return componentRemoved;
            //}
        }

        public bool RemoveComponent<T>() where T : Component
        {
            T component = GetComponent<T>();
            if (component != null)
            {
                return RemoveComponent(component);
            }
            return false;
        }


        //get component
        public T GetComponent<T>() where T : Component
        {
            foreach (Component component in _components)
            {
                if (component is T)
                {
                    return (T)component;
                }

            }
            return null;
        }
        //get components

        public T[] GetComponents<T>() where T : Component
        {
            //create an array same size as componenets
            T[] temp = new T[_components.Length];

            //copy all elements that are of type T into temp
            int count = 0;
            for (int i = 0; i < _components.Length; i++)
            {
                if (_components[i] is T)
                {
                    temp[count] = (T)_components[i];
                    count++;
                }
            }
            //trim the array
            T[] result = new T[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        private void AddComponentToRemove(Component comp)
        {
            //ensure component is not already being removed 


            foreach (Component component in _componentsToRemove)
            {
                if (component == comp)
                {
                    return;
                }
            }


            //create temp array, one bigger than _componentsToRemove, need the extra slot

            Component[] temp = new Component[_componentsToRemove.Length + 1];

            //deep copy componentsToRemove into temp

            for (int i = 0; i < _componentsToRemove.Length; i++)
            {
                temp[i] = _componentsToRemove[i];
            }


            //set last index in temp to component we wish to add

            temp[temp.Length - 1] = comp;

            //store tmep in _componenetsToRemove
            _componentsToRemove = temp;
        }

        private void RemoveComponentsToBeRemoved()
        {
            if (_componentsToRemove.Length <= 0)
            {
                return;
            }
            //create temp array for _components 
            Component[] tempComponents = new Component[_components.Length];
            


            //deep copy the array, removing the elements in _componentsToRemove
            int j = 0;
            for (int i = 0; i < _components.Length; i++)
            {
                //loop through components to remove and check if any of them is equal to this one
                bool removed = false;
               foreach(Component component in _componentsToRemove)
                {
                    if (_components[i] == component)
                    {
                        removed = true;
                        component.End();
                        break;
                    }
                }


               // if we did not find one to remove, copy the item and increment the temp array
               if (!removed)
                {
                    tempComponents[j] = _components[i];
                    j++;
                }
            }
            //trim the array

            int newLength = Math.Max(0, _components.Length - _componentsToRemove.Length);
            Component[] result = new Component[newLength];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = tempComponents[i];
            }

            // set _components
            _components = result;

        }


    }
}

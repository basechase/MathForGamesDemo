using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;


namespace MathForGamesDemo
{
    internal class Game
    {

        public void Run()
        {
            Raylib.InitWindow(800, 480, "Hello World");

            // timing stuff
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long currentTime= 0;
            double deltaTime = 1;
            long lastTime = 0;
            int fps = 1;
            int frameCount = 0;

            // Scene 
            Scene testScene = new Scene();
            testScene.Start();

            while (!Raylib.WindowShouldClose())
            {
                currentTime = stopwatch.ElapsedMilliseconds;


                


                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                testScene.Update(deltaTime);

                Raylib.EndDrawing();

                deltaTime = (currentTime - lastTime) / 1000.0;
                lastTime = currentTime;


                Console.WriteLine(deltaTime);


            }

            testScene.End();

            Raylib.CloseWindow();
        }
    }
}



    


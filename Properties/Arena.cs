using System;
using System.Collections, Generic;
using System.Linq;
using System.Text;
 namespace Snake
 {
     public enum Food{
         None = 0;
         Apple;
         Orange;
     }
     public class Arena{
         public int Width {get; private set;}
         public int Height {get; private set;}

         public SnakeModel snake{get; set;}

         public Food[,] cells {get; private set;}

         public Arena(int width, int Height){
             Width = width;
             Height = Height;

             Cells = new Food[width, height];
             Snake = new SnakeModel(this);
         }
         public void update(){
             Snake.Move();
             if (random.Next(100) <= 4) {
                 createFood();
             }
         }

         public void createFood {
             cells[random.Next(0, Width), random.Next(0, Height) = (Food)random.Next(1, 3)]
         }
     }
 }
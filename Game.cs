using System;

namespace ConsoleGame
{
  class Game : SuperGame
  {

    public new static void UpdatePosition(string keyPressed, out int x, out int y){

  switch (keyPressed){
    case "LeftArrow":
          x = 1;
          y = 0;
          break;
    case "RightArrow":
          x = 1;
          y = 0;
          break;

    case "UpArrow":
          x = 0;
          y = 1;
          break;
    case "DownArrow":
          x = 0;
          y = 1;
          break;
    case "Spacebar":
          x = 1;
          y = 0;
          break;
    default:
          x = 0;
          y = 0;
          break;

    
       }
    
   }

    public new static char UpdateCursor(string keyPressed){
 
       switch(keyPressed){

        case "LeftArrow":
         return '<';
         break;

        case "RightArrow":
         return '>';
         break;

        case "UpArrow":
         return '^';
         break;

        case "DownArrow":
         return 'v';
         break;

        default:
         return 'X';
         break;

}


    }


    public new static int KeepInBounds(int coordinate, int maxValue) {

   if(coordinate > maxValue){

     return 0;

       }

   else if(coordinate < 0){

    return maxValue;
    
       }


  else{

   return coordinate;


    }





    }


    public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit){

    if((xChar == xFruit) && (yChar == yFruit)){

      return true;

                }
    else {

      return false;

               }

      }



  }
}
    
 
using System;
using System.Collections.Generic;
using System.Text;

namespace snake_ladder
{
    class Players 
 {
       public string name;
       public int CurrentPlace;
       public int PreviousPlace;
       
  
  public Players()		 
{
            name = "";
            CurrentPlace = 1;
            PreviousPlace = 1;

}
        

public int DiceRoll()        
{
            Random random = new Random();
            return random.Next(1,7);  
}


}
}

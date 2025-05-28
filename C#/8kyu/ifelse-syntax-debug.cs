/*
While making a game, your partner, Greg, decided to create a function to check if the user is still alive called checkAlive/CheckAlive/check_alive. Unfortunately, Greg made some errors while creating the function.

checkAlive/CheckAlive/check_alive should return true if the player's health is greater than 0 or false if it is 0 or below. 
*/

// My solution

public class Player
{
  private int health = 100;
  public int Health
  {
    get
    {
      return this.health;
    }
    set
    {
      health = value;
    }
  }
  
  public Player()
  {
    
  }
  
  //FIXME: This method won't compile for some reason! :(
  public bool CheckAlive()
  {
    if (this.Health <= 0)
    {
      return false;
    }
    else
    {
      return true;
    }
  }
}
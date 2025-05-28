/*
Our football team has finished the championship.

Our team's match results are recorded in a collection of strings. Each match is represented by a string in the format "x:y", where x is our team's score and y is our opponents score.

For example: ["3:1", "2:2", "0:1", ...]

Points are awarded for each match as follows:

    if x > y: 3 points (win)
    if x < y: 0 points (loss)
    if x = y: 1 point (tie)

We need to write a function that takes this collection and returns the number of points our team (x) got in the championship by the rules given above.
*/

// My solution

using System.Linq;

public static class Kata {
    public static int TotalPoints(string[] games) 
    {
        int points = 0;
        foreach (string game in games)
        {
            int x = int.Parse(game.Split(':')[0]);
            int y = int.Parse(game.Split(':')[1]);
            
            if (x > y)
                points += 3;
            else if (x < y)
                points += 0;
            else
                points += 1;
        }
        
        return points;
    }
}
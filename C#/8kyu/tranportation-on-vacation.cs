/*
After a hard quarter in the office you decide to get some rest on a vacation. So you will book a flight for you and your girlfriend and try to leave all the mess behind you.

You will need a rental car in order for you to get around in your vacation. The manager of the car rental makes you some good offers.

Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total. Alternatively, if you rent the car for 3 or more days, you get $20 off your total.

Write a code that gives out the total amount for different days(d).

*/

//My solution

public class RentalCar {
    
    public static int RentalCarCost(int d) {
        /*
        Todos os dias com o carro alugado custa 40 dol 
        Se alugar por 7 dias ou mais você ganha 50 dol de desconto
        Se alugar por 3 dias ou mais você ganha 20 dol de desconto
        */
        int DailyCost = 40; 
        int TotalCost = d * DailyCost;   


        if (d >= 7)
        {
            TotalCost -= 50; 
        }

        else if (d >= 3)
        {
            TotalCost -= 20; 
        }

        return TotalCost;
    }
}
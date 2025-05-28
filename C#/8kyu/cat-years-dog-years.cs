/*
I have a cat and a dog.

I got them at the same time as kitten/puppy. That was humanYears years ago.

Return their respective ages now as [humanYears,catYears,dogYears]

NOTES:

    humanYears >= 1
    humanYears are whole numbers only

Cat Years

    15 cat years for first year
    +9 cat years for second year
    +4 cat years for each year after that

Dog Years

    15 dog years for first year
    +9 dog years for second year
    +5 dog years for each year after that
*/

// My solution

public class Dinglemouse {

public static int[] humanYearsCatYearsDogYears(int humanYears) {
    if (humanYears >= 1)
    {
        int catYears = 0;
        int dogYears = 0;
        int result = 0;

        switch (humanYears)
        {
            case 1:
                result = 15;
                break;
            case 2:
                result = 15 + 9;
                break;
            default:
                result = 15 + 9 + (humanYears - 2) * 4;
                break;
        }

        catYears = result;
        dogYears = result;

        switch (humanYears)
        {
            case 1:
                dogYears = 15;
                break;
            case 2:
                dogYears = 15 + 9;
                break;
            default:
                dogYears = 15 + 9 + (humanYears - 2) * 5;
                break;
        }

        return new int[] { humanYears, catYears, dogYears };
    }

    return null;
}

}
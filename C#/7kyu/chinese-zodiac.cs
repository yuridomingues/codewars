/*
The Chinese zodiac is a repeating cycle of 12 years, with each year being represented by an animal and its reputed attributes. The lunar calendar is divided into cycles of 60 years each, and each year has a combination of an animal and an element. There are 12 animals and 5 elements; the animals change each year, and the elements change every 2 years. The current cycle was initiated in the year of 1984 which was the year of the Wood Rat.

Since the current calendar is Gregorian, I will only be using years from the epoch 1924. For simplicity I am counting the year as a whole year and not from January/February to the end of the year.

##Task

Given a year, return the element and animal that year represents ("Element Animal"). For example I'm born in 1998 so I'm an "Earth Tiger".

animals (or $animals in Ruby) is a preloaded array containing the animals in order:

['Rat', 'Ox', 'Tiger', 'Rabbit', 'Dragon', 'Snake', 'Horse', 'Goat', 'Monkey', 'Rooster', 'Dog', 'Pig']

elements (or $elements in Ruby) is a preloaded array containing the elements in order:

['Wood', 'Fire', 'Earth', 'Metal', 'Water']

Tell me your zodiac sign and element in the comments. Happy coding :)
*/

//My solution
public partial class Kata
{
    public static string ChineseZodiac(int year)
    {
        /*
        Chinese zodiac 12 years cicle
        Lunar calendar 60 years cicle
        Each year, changes the animal
        Each 2 years, changes the element
        12 animals and 5 elements
        */

        string[] animals = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
        string[] elements = { "Wood", "Fire", "Earth", "Metal", "Water" };

        int baseYear = 1924;

        if (year < baseYear)
        {
            return "Please, send a year above 1924";
        }

        int animalIndex = (year - baseYear) % 12;
        int elementIndex = ((year - baseYear) / 2) % 5;

        return $"{elements[elementIndex]} {animals[animalIndex]}";
    }
}

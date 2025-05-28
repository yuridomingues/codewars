/*
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F
*/

// My solution

using System;

public class Kata
{
  public static char GetFirstChar (string name)
  {
   return char.ToUpper(name[0]);
  }
  
  public static string AbbrevName(string name)
  {
    // 1.
    string[] ListNames = name.Split(' ');
    
    // 2.
    string FirstName = ListNames[0];
    string LastName = ListNames[1];
  
    // 3.
    return GetFirstChar(FirstName) + "." + GetFirstChar(LastName);
  }
}

// Sam Harris
// 1 - Dividir o nome em palavras ( ["Sam", "Harris"]) ✅
// 2 - Pegar as letras maisculas de cada palavra ["S", "H"] ✅
  // 2.1 - Caso tenha uma letra maiuscula gostaria que colocasse ela em alguma variavel ✅
// 3 - Adicionar as letras ao resultado, com um ponto no meio ("S.H") ✅
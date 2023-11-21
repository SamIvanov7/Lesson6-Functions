using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Демонстрація функцій з прикладами вхідних даних

        // Task 1: Функція для обчислення степені числа
        Console.WriteLine("Power of 4^8: " + CalculatePower(4, 8));

        // Task 2:  Функція для обчислення суми чисел у заданому діапазоні
        Console.WriteLine("Sum of numbers between 3 and 25: " + SumRange(3, 25));

        // Task 3: Функція для пошуку досконалих чисел
        List<int> perfectNumbers = FindPerfectNumbers(1, 3000);
        Console.WriteLine("Perfect numbers between 1 and 3000: " + String.Join(", ", perfectNumbers));

        // Task 4: Функція для виведення карти за її номером у колоді
        string[] cards = { "Ace of Spades", "King of Hearts", "Queen of Clubs" };
        PrintCard(cards, 2); // Prints the second card

        // Task 5:  Функція для перевірки, чи є число "щасливим"
        Console.WriteLine("Is 222888 a lucky number? " + IsLuckyNumber(222888));
        Console.WriteLine("Is 232848 a lucky number? " + IsLuckyNumber(232848));
    }

    /// <param name="baseNumber">Основа степеня.</param>
    /// <param name="exponent">Показник степеня.</param>
    /// <returns> Результат піднесення числа до степеня. </returns>
    public static double CalculatePower(double baseNumber, int exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }


    /// <param name="start">Початок діапазону.</param>
    /// <param name="end">Кінець діапазону.</param>
    /// <returns> Сума чисел у діапазоні. </returns>
    public static int SumRange(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        return sum;
    }


    /// <param name="start">Початок діапазону.</param>
    /// <param name="end">Кінець діапазону.</param>
    /// <returns> Список досконалих чисел у діапазоні. </returns>
    public static List<int> FindPerfectNumbers(int start, int end)
    {
        List<int> perfectNumbers = new List<int>();

        for (int i = start; i <= end; i++)
        {
            int sum = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    sum += j;
                }
            }

            if (sum == i)
            {
                perfectNumbers.Add(i);
            }
        }

        return perfectNumbers;
    }


    /// <param name="cards">Масив карт.</param>
    /// <param name="cardIndex">Індекс карти у масиві.</param>
    public static void PrintCard(string[] cards, int cardIndex)
    {
        if (cardIndex >= 0 && cardIndex < cards.Length)
        {
            Console.WriteLine("Card: " + cards[cardIndex]);
        }
        else
        {
            Console.WriteLine("Invalid card index.");
        }
    }


    /// <param name="number">Число для перевірки.</param>
    /// <returns> Повертає true, якщо число є "щасливим".</returns>
    public static bool IsLuckyNumber(int number)
    {
        if (number < 100000 || number > 999999)
        {
            return false; // Number is not a six-digit number
        }

        int firstPart = number / 1000;      // Extract the first three digits
        int secondPart = number % 1000;     // Extract the last three digits

        return firstPart / 100 == firstPart / 10 % 10 &&
               firstPart / 10 % 10 == firstPart % 10 &&
               secondPart / 100 == secondPart / 10 % 10 &&
               secondPart / 10 % 10 == secondPart % 10 &&
               firstPart != secondPart;
    }
}

using System;

/// <summary>
/// Сводное описание для Class1
/// </summary>
/// 

    public class Electors
    {
        public int choice;

        public Electors(int candidate)
        {
            choice = candidate;
        }

        public void SetChoice(int candidate)
        {
            choice = candidate;
        }
    }
using System;
using System.Collections;
using System.Collections.Generic;


public static class DiceSimulator 
{
    private static IntMemento intMemento = new IntMemento();

    public static string Roll(string command)
    {
        var toReturn = string.Empty;
        int diceSum = 0;
        var commandSplited = command.Split('d');
        if (string.IsNullOrEmpty(commandSplited[0]))
            commandSplited[0] = 1.ToString();
        if (string.IsNullOrEmpty(commandSplited[1]))
            commandSplited[1] = 0.ToString();
        for(int i = 0; i< Convert.ToInt32(commandSplited[0]); i++)
        {
            var diceValue = GenerateValue(Convert.ToInt32(commandSplited[1]));
            toReturn += diceValue.ToString() + ",";
            diceSum += diceValue;
        }
        toReturn += "\nSum: " + diceSum.ToString();
        return toReturn;
    }

    private static int GenerateValue(int max = 0)
    {
        var random  = new Random(Guid.NewGuid().GetHashCode());
        int toReturn = 0;
        if (intMemento.Update(random.Next(1, max + 1)))
            toReturn = random.Next(1, max + 1);
        else
            toReturn = intMemento.RandomValue;

        return toReturn;
            
    }
}

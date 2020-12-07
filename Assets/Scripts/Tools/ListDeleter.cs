using System.Collections;
using System.Collections.Generic;

public static class ListDeleter
{
    static public void DeleteFromList(IList list, int indexToDelete)
    {
        int tmpLimit = list.Count - 1;
        if (list.Count > indexToDelete)
        {
            if (indexToDelete < tmpLimit)
            {
                for (int i = indexToDelete; i < tmpLimit; i++)
                {
                    list[i] = list[i + 1];
                }
            }
            list.RemoveAt(tmpLimit);
        }
    }
}

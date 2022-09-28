using UnityEngine;

public class DataFile
{
    public string name;
    public string date;
    public int score;

    public DataFile(string aName, string bDate, int aScore)
    {
        name = aName;
        date = bDate;
        score = aScore;
    }
}

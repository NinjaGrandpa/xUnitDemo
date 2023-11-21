using System.Reflection.Metadata.Ecma335;
using xUnitDemo.Interfaces;

namespace xUnitDemo;

public class StringJoiner : IStringJoiner
{
    public string JoinStrings(string[] arrayToJoin)
    {
        var joinedString = "";

        foreach (var item in arrayToJoin)
        {
            joinedString += item;
        }

        return joinedString;
    }
}
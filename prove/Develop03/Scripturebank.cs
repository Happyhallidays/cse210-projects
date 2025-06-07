using System;
using System.Collections.Generic;

public static class ScriptureBank
{
    private static List<Scripture> _scriptures = new List<Scripture>
    {
        new Scripture("Ether", 12, 11,
            "Wherefore, by faith was the law of Moses given. But in the gift of his Son hath God prepared a more excellent way; and it is by faith that it hath been fulfilled."),
        
        new Scripture("Jacob", 7, 5,
            "And he had hope to shake me from the faith, notwithstanding the many revelations and the many things which I had seen concerning these things; for I truly had seen angels, and they had ministered unto me. And also, I had heard the voice of the Lord speaking unto me in very word, from time to time; wherefore, I could not be shaken."),
        
        new Scripture("Revelations", 21, 4,
            "And God shall wipe away all tears from their eyes; and there shall be no more death, neither sorrow, nor crying, neither shall there be any more pain: for the former things are passed away."),
        
        new Scripture("Ezekiel", 37, 15, 17,
            "The word of the Lord came again unto me, saying, Moreover, thou son of man, take thee one stick, and write upon it, For Judah, and for the children of Israel his companions: then take another stick, and write upon it, For Joseph, the stick of Ephraim, and for all the house of Israel his companions: And join them one to another into one stick; and they shall become one in thine hand.")
    };

    public static Scripture GetRandomScripture()
    {
        var random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }

    public static List<Scripture> GetAllScriptures()
    {
        return _scriptures;
    }
}

public class Solution {
   public bool IsAnagram(string s, string t)
{
    Dictionary<char,int> sCounter = new Dictionary<char,int>();
    Dictionary<char,int> tCounter= new Dictionary<char,int>();
    for(int i = 0; i < s.Length; i++)
    {
        if (sCounter.ContainsKey(s[i]))
        {
            sCounter[s[i]]++;
        }
        else
        {
            sCounter.Add(s[i], 1);
        }
    }
    for (int i = 0; i < t.Length; i++)
    {
        if (tCounter.ContainsKey(t[i]))
        {
            tCounter[t[i]]++;
        }
        else
        {
            tCounter.Add(t[i], 1);
        }
    }
    if(sCounter.Count !=tCounter.Count)
        return false;
    foreach(char k in sCounter.Keys)
    {
        if(!tCounter.ContainsKey(k))
            return false;
        if (sCounter[k]!=tCounter[k])
            return false;
    }
    return true;
}
}

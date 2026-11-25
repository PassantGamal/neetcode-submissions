public class Solution {
    public string LongestCommonPrefix(string[] strs)
 {
     if (strs.Length == 0)
         return "";
     string first = strs[0];
     for (int i = 1; i < strs.Length; i++) 
     {
         while(first.Length>0&&!strs[i].StartsWith(first))
            first=first.Substring(0, first.Length - 1);
     }
     return first;
 }
}
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        {
            return false;
        }
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        string result = new string(chars);

        char[] charst = t.ToCharArray();
        Array.Sort(charst);
        string resultt = new string(charst);
        return result==resultt;
    }
    public bool IsAnagramm(string s, string t)
    {
        
        
        Dictionary<char,int> dicts=new Dictionary<char,int>();
        Dictionary<char,int> dictt=new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(dictt.ContainsKey(t[i]))
            {
                dictt[t[i]]++;
            }
            else
            {
                dictt[t[i]]=1;
            }

            if(dicts.ContainsKey(s[i]))
            {
                dicts[s[i]]++;
            }
            else
            {
                dicts[s[i]]=1;
            }
        }
        if(dicts.Count!=dictt.Count)
        {
            return false;
        }
        for(int i=0;i<s.Length;i++)
        {
            if(dicts.ContainsKey(s[i]))
            {
                if(dictt.ContainsKey(s[i]))
                {
                    if(dictt[s[i]]!=dicts[s[i]])
                        return false;
                }
                else
                {
                    return false;
                }
                
            }
            
        }
        return true;
    }
}

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<string> list=new List<string>();
        for(int i=0;i<strs.Length;i++)
        {
            list.Add(strs[i]);
        }
        List<List<string>> ans=new List<List<string>>();
        bool[] visited =new bool[strs.Length];
        for(int i=0;i<list.Count;i++)
        {
            List<string> res=new List<string>();
            res.Add(list[i]);
            //Console.WriteLine(string.Join(", ", visited));
            if(!visited[i])
                isAnagram(list,i,res,visited);
            if(!visited[i])
                ans.Add(res); 
            visited[i]=true;
            //Console.WriteLine(string.Join(", ", visited));
               
        }
        return ans;
    }
    public void isAnagram(List<string> list,int currindex,List<string> res,bool[] visited)
    {
        for(int i=currindex+1;i<list.Count;i++)
        {
            if(list[i].Length!=list[currindex].Length)
            {
                continue;
            }
            if(!visited[currindex] && !visited[i] && checkAnagram(list[i],list[currindex]))
            {
                res.Add(list[i]);
                visited[i]=true;
            }
        }
    }
    public bool checkAnagram(string p,string up)
    {
        if(p.Equals(up))
        {
            return true;
        }
        //Dicitonary<char,int> dict=new Dictionary<char,int>();
        Dictionary<char,int> dictu=new Dictionary<char,int>();
        for(int i=0;i<p.Length;i++)
        {
            // if(dict.ContainsKey(p[i]))
            // {
            //     dict[p[i]]++;
            // }
            // else
            // {
            //     dict[p[i]]=1;
            // }

            if(dictu.ContainsKey(up[i]))
            {
                dictu[up[i]]++;
            }
            else
            {
                dictu[up[i]]=1;
            }
        }

        for(int i=0;i<p.Length;i++)
        {
            //Console.WriteLine(dictu[p[i]]);
            if(dictu.ContainsKey(p[i]))
            {
                dictu[p[i]]--;
            }
        }
        foreach(var duck in dictu)
        {
            //Console.WriteLine(duck.Key+" "+duck.Value);
            if(duck.Value!=0)
            {
                return false;
            }
        }
        return true;
    }
    
}

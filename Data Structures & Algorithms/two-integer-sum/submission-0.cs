public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            int temp=target-nums[i];
            if(dict.ContainsKey(temp))
            {
                return new int[] { dict[temp], i };
            }

            
                dict[nums[i]]=i;
            
        }
        return new int[] { };
    }
    public int[] bruteforceapproach(int[] nums,int target)
    {
        int[] ans=new int[2];
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=1;j<nums.Length;j++)
            {
                if(i!=j)
                {
                    if((nums[i]+nums[j])==target)
                    {
                        ans[0]=i;
                        ans[1]=j;
                        return ans;
                    }
                }
            }
        }
        return ans;
    }
}

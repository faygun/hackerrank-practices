/*
    https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
*/

public static class WarmUpChallenges
{
    public static int sockMerchant(int n, List<int> ar)
    {
        int result = 0;
        
        if(n < 1 || n > 100)
            throw new ArgumentOutOfRangeException();
        
        if(ar.Count > n)
            throw new ArgumentOutOfRangeException();
        
        var hasMap = new Dictionary<int, int>();
        
        for(int i = 0; i < ar.Count; i++)
        {
            var item = ar[i];
            if(hasMap.ContainsKey(item))
            {
                hasMap[item] = hasMap[item] + 1;
            }
            else
                hasMap[item] = 1;
        }
        
        foreach(var item in hasMap)
        {
            result += item.Value/2;
        }
        
        return result;
    }
}
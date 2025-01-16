public static class WarmUpChallenges
{
    /*
        https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    */
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

    /*
        https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    */
    public static int countingValleys(int steps, string path)
    {
        var result = 0;
        if(steps < 2 || steps > Math.Pow(10, 6))
            throw new ArgumentOutOfRangeException();
        
        var seaLevel = 0;
        var everStayBelowSeaLevel = false;
        for(int i = 0; i < path.Length; i++)
        {
            if(path[i] == 'D')
            {
                seaLevel -= 1;   
                if(!everStayBelowSeaLevel && seaLevel < 0)
                    everStayBelowSeaLevel = true;
            }
            else
            {
                seaLevel += 1;
            }
             
            if(seaLevel == 0)    
            {
                if(everStayBelowSeaLevel)
                {
                    everStayBelowSeaLevel = false;   
                    result++;
                }
            }
            
        }
        return result;
    }

    /*
        https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    */
    public static int jumpingOnClouds(List<int> c)
    {
        var result = 0;
        var index = 0;
        if(c == null || c.Count < 2 || c.Count > 100 || c[0] != 0)
            throw new ArgumentException();
            
        while(index < c.Count - 1)
        {
            index += 2;
            
            if(index > c.Count - 1 || c[index] == 1)
                index -= 1;
            
            result++;
                
        }
        
        return result;
    }

    /*
        https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    */
    public static long repeatedString(string s, long n)
    {
        if(s.Length < 1 || s.Length > 100)
            throw new InvalidDataException();
        if(n < 1 || n > Math.Pow(10,12))
            throw new InvalidDataException();
        
        var repeatCountOfA = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a')
             repeatCountOfA++;
        }

        // 1
        var remainig = n % s.Length;
        // 3
        var result = n / s.Length;
        
        result = result * repeatCountOfA;
        
        for(int i = 0; i < remainig; i++)
        {
            if(s[i] == 'a')
                result++;
        }
        
        return result;
    }
}


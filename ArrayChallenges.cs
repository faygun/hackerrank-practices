public static class ArrayChallenges
{
    /*
        https://www.hackerrank.com/challenges/2d-array/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    */
     public static int hourglassSum(List<List<int>> arr)
    {
        var sumList = new List<int>();
        int i = 0;
        int j = 0;
        while(i < 4)
        {
            var sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + 
                    arr[i + 1][j+ 1] + 
                    arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

            sumList.Add(sum);

            j++;

            if(j == 4)
            {
                i++;
                j = 0;
            } 
        }
        return sumList.Max();
    }

    /*
        https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    */

    public static List<int> rotLeft(List<int> a, int d)
    {
        var size = a.Count;
        var res = new int[size];
        if(size == d)
            return a;
        
        
        for(var i = 0; i < size; i++){
            if(size + i - d >= size)
                res[i - d] = a[i];
            else
                res[size + i - d] = a[i];
        }
        
        return res.ToList();
    }

}
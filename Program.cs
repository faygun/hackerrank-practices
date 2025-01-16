// var sockMerchantResult = WarmUpChallenges.sockMerchant(9, new List<int>{10, 20, 20, 10, 10, 30, 50, 10, 20});
// Console.WriteLine("StockMerchantResult = {0}", sockMerchantResult);

var arrayList = new List<List<int>>
{
    new List<int>{-9, -9, -9,  1, 1, 1},
    new List<int>{-0, -9,  0,  4, 3, 2},
    new List<int>{-9, -9, -9,  1, 2, 3},
    new List<int>{-0,  0,  8,  6, 6, 0},
    new List<int>{ 0,  0,  0, -2, 0, 0},
    new List<int>{ 0,  0,  1,  2, 4, 0}
};

// var arrayList = new List<List<int>>
// {
//     new List<int>{-1, 1, -1, 0, 0, 0},
//     new List<int>{ 0, -1, 0, 0, 0, 0},
//     new List<int>{-1, -1, -1, 0, 0, 0},
//     new List<int>{ 0, -9, 2, -4, -4, 0},
//     new List<int>{-7, 0, 0, -2, 0, 0},
//     new List<int>{ 0, 0, -1, -2, -4, 0}
// };

// 28
var hourGlassResult = ArrayChallenges.hourglassSum(arrayList);
Console.WriteLine("hourGlassResult : {0}", hourGlassResult);



Console.Read();

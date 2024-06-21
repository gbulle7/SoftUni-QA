List<int> arr1 = new List<int>();
List<int> arr2 = new List<int>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (i % 2 == 0)
    {
        arr1.Add(nums[0]);
        arr2.Add(nums[1]);
    }
    else if (i % 2 != 0) 
    {
        arr2.Add(nums[0]);
        arr1.Add(nums[1]);
    }
}
Console.WriteLine(string.Join(" ", arr1));
Console.WriteLine(string.Join(" ", arr2));
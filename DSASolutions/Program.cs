// See https://aka.ms/new-console-template for more information

namespace DSASolutions;

public class Program
{
    public static void Main(String[] args)
    {
        int[] nums1 =  { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] nums2 =  { 2, 5, 6 };
        int n = 3;
        ArraysAndStrings.merge(nums1, m, nums2, n);
    }
}
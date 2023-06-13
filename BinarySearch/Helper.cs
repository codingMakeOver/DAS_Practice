namespace _744_Find_Smallest_Letter_Greater_Than_Target;

/*
 * Problem : https://leetcode.com/problems/find-smallest-letter-greater-than-target/
 * In this problem all the character is sorted in lexicographically
 * When we have shorted array best way to find an element is binary search
 */

public static class Helper
{
    public static char NextGreatestLetter(char[] letters, char target)
    {
        int l=0, r = letters.Length - 1;
        while (l <= r)
        {
            int middle = (l+r)/2;
            if (letters[middle] <= target)
                l = middle + 1;
            else
                r = middle - 1;

        }
        return letters[l%letters.Length];
    }
}

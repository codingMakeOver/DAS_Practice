namespace _1318_Minimum_Flips;

public static class Filp
{
    public static int MinFlips(int a, int b, int c)
    {
        // convert to binary
        string _a = Convert.ToString(a,2);
        string _b = Convert.ToString(b,2);
        string _c = Convert.ToString(c,2);

        // append zero if needed
        int mx = Math.Max(Math.Max(_a.Length,_b.Length),_c.Length);
        /*
         * check if the max - _a1 length is 0 
         * then no need to append any zero
         */
        _a = AppendZero(_a, mx - _a.Length);
        _b = AppendZero(_b, mx - _b.Length);
        _c = AppendZero(_c, mx - _c.Length);

        // compare a and b
        int r = 0, i = 0;
        while (i < mx)
        {
            /*
             * only two condition we need to flip
             * 1. if required output needs to be 1 but both input (a,b) are 0
             * 2. if required output needs to be 0 but both or one of the input is 0
             */
            if (_c[i] == '1' && (_a[i] == '0' && _b[i] == '0'))
                r++;
            else if (_c[i] == '0' && (_a[i] == '1' || _b[i] == '1'))
            {
                if (_a[i] == '1') r++;
                if (_b[i] == '1') r++;
            }
            i++;
        }
        return r;
    }

    // padding is like based on the length , if i add 1 means make the total length to 1. as it is already more than 1 length this will not append anything
    private static string AppendZero(string a, int l) => l > 0 ? a.PadLeft((l + a.Length), '0') : a;
}
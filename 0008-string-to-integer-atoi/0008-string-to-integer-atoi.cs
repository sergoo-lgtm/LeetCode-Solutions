public class Solution {
    public int MyAtoi(string s) {
        if (string.IsNullOrEmpty(s))
            return 0;

        int i = 0;
        int n = s.Length;

        while (i < n && s[i] == ' ')
            i++;

        if (i == n)
            return 0;

        int sign = 1;
        if (s[i] == '-') {
            sign = -1;
            i++;
        } else if (s[i] == '+') {
            i++;
        }

        int result = 0;

        while (i < n && char.IsDigit(s[i])) {
            int digit = s[i] - '0';

            if (result > (int.MaxValue - digit) / 10) {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }
}
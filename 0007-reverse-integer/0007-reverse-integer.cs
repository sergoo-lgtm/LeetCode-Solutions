public class Solution {
    public int Reverse(int x) {
        int result = 0;
        
        while (x != 0) {
            int digit = x % 10;   // ناخد اخر رقم
            x /= 10;              // نشيل اخر رقم
            
            // نتحقق من overflow
            if (result > int.MaxValue / 10 || result < int.MinValue / 10) {
                return 0;
            }
            
            result = result * 10 + digit;
        }
        
        return result;
    }
}
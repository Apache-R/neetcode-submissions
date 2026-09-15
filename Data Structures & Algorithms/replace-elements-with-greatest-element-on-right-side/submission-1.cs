public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int h = arr[arr.Length-1];
        int temp = 0;
        for(int i = arr.Length - 1; i > 0; i--){
            temp = arr[i-1];
            arr[i-1] = h;
            if(temp >= h)
                h = temp;
        }
        arr[arr.Length-1] = -1;

        return arr;
    }
}
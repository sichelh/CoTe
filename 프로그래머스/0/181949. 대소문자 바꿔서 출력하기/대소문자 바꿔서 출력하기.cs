using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        Char[] chars = s.ToCharArray();
        
        for (int i =0; i < chars.Length; i++){
            if (chars[i] >= 'A' && chars[i] <= 'Z'){
                chars[i] += (char)32;
            }
            else{
                chars[i] -= (char)32;
            }
            Console.Write(chars[i].ToString());
        }
    }
}
using System;
using System.Text.RegularExpressions;

//Entrada
//A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.
//saída
//A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.


public class Program
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for ( int i =0; i < n; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (int i=0; i < nums.Length; i++ )
        {
            if ( major == nums[i])
            {
                count ++ ;
            }
            else
            {
                count--;
                if (count < 1)
                {
                   major = nums[i];
                  count = 1;
                }
                else
                {
                    count--;
                }
            }
        }
        return    major      ;
    }
}
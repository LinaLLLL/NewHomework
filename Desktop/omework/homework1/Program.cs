// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Text.RegularExpressions;
//1 задача
/*void OneTon(int n, int m){
    if(m>n){
        OneTon(n, m-1);
        System.Console.WriteLine(m +" ");
    }
}
OneTon(1, 5);*/

//2 задача
/*int m = 3;
int n = 2;
int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Write($"Функция Аккермана равна {akkerman(m, n)} ");*/

//3 задача
int[] arr = {1,5,6};

void ShowArr(int[] arr, int i=0){
    if(i<arr.Length){
        ShowArr(arr, i+1);
        Console.Write(arr[i]+"  ");

    }
}
ShowArr(arr);
//////
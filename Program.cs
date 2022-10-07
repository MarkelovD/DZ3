//задача 1
Console.WriteLine("введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if ((num%10)==(num/10000) && (num/10%10) == (num/1000%10)){
    Console.WriteLine($"число {num} является палиндромом");
}
else{
    Console.WriteLine($"число {num} не является палиндромом");
}
//задача 1
// Console.WriteLine("введите пятизначное число");
// int num = int.Parse(Console.ReadLine()!);
// if ((num%10)==(num/10000) && (num/10%10) == (num/1000%10)){
//     Console.WriteLine($"число {num} является палиндромом");
// }
// else{
//     Console.WriteLine($"число {num} не является палиндромом");
// }

//задача 2
// int a_x = int.Parse(Console.ReadLine()!);
// int a_y = int.Parse(Console.ReadLine()!);
// int a_z = int.Parse(Console.ReadLine()!);
// int b_x = int.Parse(Console.ReadLine()!);
// int b_y = int.Parse(Console.ReadLine()!);
// int b_z = int.Parse(Console.ReadLine()!);
// double rast = Math.Sqrt(Math.Pow(b_x-a_x,2)+Math.Pow(b_y-a_y,2)+Math.Pow(b_z-a_z,2));
// Console.WriteLine($"расстояние между 2мя точками в 3D пространстве равно {Math.Round(rast,2)}");

//задача 3
Console.WriteLine("введите число число");
int num = int.Parse(Console.ReadLine()!);
int i = 1;
while (i<=num){
Console.WriteLine($"куб числа {i} равен {Math.Pow(i,3)}");
i++;
}
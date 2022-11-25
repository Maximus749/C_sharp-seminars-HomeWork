Console.Write("Insert number please: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 == 0){
    Console.WriteLine("Число " + number1 + " - четное.");
}
else{
    Console.WriteLine("Число " + number1 + " - нечетное.");
}
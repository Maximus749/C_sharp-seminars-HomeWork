// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите индекс дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());


if (day <= 7){
    if (day == 1){
            Console.WriteLine("Понедельник, Не выходной");
        }
    if (day == 2){
            Console.WriteLine("Вторник, Не выходной");
        }
    if (day == 3){
            Console.WriteLine("Среда, Не выходной");
        }
    if (day == 4){
            Console.WriteLine("Четверг, Не выходной, но уже скоро");
        }
    if (day == 5){
            Console.WriteLine("Пятница, Еще чуть чуть");
        }
    if (day == 6){
            Console.WriteLine("Суббота, Ура, выходной");
                }
    if (day == 7){
            Console.WriteLine("Воскресенье, выходной. Но будь внимателен, завтра на работу!");
        }
}
else{
    Console.WriteLine("Не угадал, в неделе 7 дней");
}

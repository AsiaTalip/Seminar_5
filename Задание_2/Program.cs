using System;

class Program {
    static void Main() {
        // Создаем массив случайных чисел
        int[] arr = new int[4];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rand.Next(-100, 100);
        }
        
        // Вычисляем сумму элементов на нечетных позициях
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2) {
            sum += arr[i];
        }
        
        Console.WriteLine("Массив: " + string.Join(", ", arr));
        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
    }
}
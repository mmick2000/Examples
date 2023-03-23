// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count){
// Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 8, msg: "Новое сообщение");

int Method3()
{
    return DateTime.Now.Year;
}

int date = Method3();
// System.Console.WriteLine(date);

// string Method4(int count, string text)
// {
//     int i=0;
//     string result = String.Empty; // что означает ""; пустая строка;
//     while(i <count){
// result = result  + text;
//         i++;
//     }
//     return result;
// }

// string  txt = Method4(text: "Ура! ", count: 6);
// System.Console.WriteLine(txt);

string MethodFor4_2(int count, string text)
{
    string result = String.Empty; // что означает ""; пустая строка;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string txt = MethodFor4_2(text: "ZZZ ", count: 18);
// System.Console.WriteLine(txt);


// for (int i = 0; i < 10; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j};  ");
//     }
//     System.Console.WriteLine();
// }

// Работа-с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками
// маленькие’буквы "к" заменить-большими "К",
// а большие "С" заменить’маленькими "C".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля. "
// + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty";
// // System.Console.WriteLine(s[3]);

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// // string newText = Replace(text, ' ', '|');
// // Console.WriteLine(newText);
// Console.WriteLine(Replace(text, ' ', '|'));
// Console.WriteLine(Replace(text, 'к', 'К'));
// Console.WriteLine(Replace(text, 'С', 'с'));

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    // int count = array.Length;
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minposition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
if(array[j] < array[minposition]) minposition = j;
        }

        int temporary = array[i];
        array[i] = array[minposition];
        array[minposition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

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

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty; // что означает ""; пустая строка;
    while(i <count){
result = result  + text;
        i++;
    }
    return result;
}

string  txt = Method4(text: "Ура! ", count: 6);
System.Console.WriteLine(txt);
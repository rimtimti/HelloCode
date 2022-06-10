using System;
Console.Clear();
//метод заполнения массива рандомными числами
void FillArray (int [] collection) {
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection [index] = new Random().Next(1,10);
    index++;
    }
}
//метод печати массива
void PrintArray (int [] coll) {
    int count = coll.Length;
    int pos = 0;
    while (pos < count){
        Console.WriteLine(coll[pos]);
    pos++;
    }
}
//метод по поиску индекса нужного числа в массиве
int IndexOf (int [] collection, int find){
    int count = collection.Length;
    int index = 0;
    int position = -1;//если элемента нет, то выдаст -1, а не 0 ))
    while (index < count){
        if (collection[index] == find){
            position = index;
            break;//если нужен только первый индекс, то это... без break будет последний индекс
        }
        index++;
    }
    return position;
}

int [] array = new int [10];
FillArray (array);
PrintArray (array);

Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);
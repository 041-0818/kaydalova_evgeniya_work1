// ["hello", "2", "world", "12w"] -> ["2","12w"]

void PrintArr(string[] arr) {

    int counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++){
        if (arr[i].Length <= 3) {
            counter++;
        }
    }

    // недостаток алгоритма в том, что выполняем два прохода по массиву, 
    // но из-за невозможности использовать List (ограничение в условии задачи), 
    // мы заранее не можем указать длинну результирующего массива, 
    // не посчитав заранее колличество эллементов, которые собираемся в него положить
    string[] filteredArr = new string[counter];
    counter = 0;
    for (int i = 0; i < arr.GetLength(0); i++){
        if (arr[i].Length <= 3) {
            filteredArr[counter++] = arr[i];
        }
    }

    Console.WriteLine("------------------------------------------------------------------------");
    Console.Write("Исходный массив:[{0}] ", String.Join(",",arr));
    Console.Write(" -> ");
    Console.Write("Массив с элементами, длинна которых не превышает 3 символов:[{0}] ", String.Join(",",filteredArr));

}

string[] arr = {"hello", "2", "world", "12w"};
PrintArr(arr);
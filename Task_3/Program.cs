void ShowArray(int [] array, int i=0){
    if(i<array.Length){
        Console.Write(array[i]+" ");
        ShowArray(array, i+1);
    }
}

void ShowReverseArray (int [] array, int i=0){
    if(i<array.Length){
        Console.Write(array[array.Length-1-i] + " ");
        ShowReverseArray(array, i+1);
    }
}

int [] array = {4, -51, 5, 0, -1, 9, 54, 1, 12};
ShowArray(array);
Console.Write("=> ");
ShowReverseArray(array);
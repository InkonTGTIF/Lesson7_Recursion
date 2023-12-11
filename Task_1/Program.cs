void NaturalNumber(int n, int m){
    if(n>m) return;
    else{
        Console.Write(n+" ");
        NaturalNumber(n+1,m);
    }
}

int n = 20;
int m = 7;

Console.Write($"N={n}; M={m} => ");

if(n<0 && m<0){
    Console.WriteLine($"Введненные числа ({n}) и ({m}) не являются натуральнымы");
    return;
}
else if(n<0){
    Console.WriteLine($"Введненное число ({n}) не является натуральным");
    return;
}
else if(m<0){
    Console.WriteLine($"Введненное число ({m}) не является натуральным");
    return;
}

if(n>m){
    int temp = n;
    n = m;
    m = temp;
}

NaturalNumber(n,m);
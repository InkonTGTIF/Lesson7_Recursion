int AckermannFunction(int m, int n){
    if(m==0){
        return n + 1;
    }
    if(m>0 && n==0){
        return AckermannFunction(m - 1, 1);
    }
    else{
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

int m = 3;
int n = 4;

Console.Write($"m={m}, n={n} => ");

if(n<0 && m<0){
    Console.WriteLine($"Введненные числа ({n}) и ({m}) являются отрицательными");
    return;
}
else if(n<0){
    Console.WriteLine($"Введненное число ({n}) является отрицательным");
    return;
}
else if(m<0){
    Console.WriteLine($"Введненное число ({m}) является отрицательным");
    return;
}

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m, n)}");
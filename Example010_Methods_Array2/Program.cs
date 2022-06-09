using System;
using static System.Console;
Clear();

int [] numbers = {233,32,44,54,36,76,89,22,36};

int n = numbers.Length;
int find = 36;
int index = 0;
while (index < n) {
    if (numbers [index] == find) {
        WriteLine (index);
        break;
    }
    index++;
}

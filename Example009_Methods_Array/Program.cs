using System;
using static System.Console;
Clear();

int [] numbers = {233,32,44,54,36,76,89,22,13};

int Max (int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max = Max (Max (numbers[0],numbers[1],numbers[2]), Max (numbers[3],numbers[4],numbers[5]), Max (numbers[6],numbers[7],numbers[8]));

Write(max);
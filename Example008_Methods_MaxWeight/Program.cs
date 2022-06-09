using System;
using static System.Console;
Clear();

int a1 = 23,
    a2 = 32,
    a3 = 44,
    b1 = 54,
    b2 = 36,
    b3 = 76,
    c1 = 89,
    c2 = 22,
    c3 = 13;

int Max (int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max = Max (Max (a1,a2,a3), Max (b1,b2,b3), Max (c1,c2,c3));
/*int max1 = Max (a1,a2,a3);
int max2 = Max (b1,b2,b3);
int max3 = Max (c1,c2,c3);
int max = Max (max1,max2,max3);*/

/*int max = a1;
if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (b1 > max) max = b1;
if (b2 > max) max = b2;
if (b3 > max) max = b3;
if (c1 > max) max = c1;
if (c2 > max) max = c2;
if (c3 > max) max = c3;*/
Write(max);
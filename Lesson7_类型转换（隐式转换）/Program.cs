// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("类型转换（隐式转换）");
//什么是类型转换

//类型转换就是不同变量类型之间的相互转换

//隐式转换的基本规则一>不同类型之间自动转换
//大范围装小范围

#region 知识点一 相同大类型之间的转换
// 有符号  long -> int -> short -> sbyte
long l = 1;
int i = 1;
short s = 1;
sbyte sb = 1;
//隐式转换 int隐式转换成了long
//可以用大范围装小范围
l = i;
//半年永小范围的类型装大范围的类型
//i = l；（X）

//无符号    ulong -> uint -> ushort ->byte
ulong ul = 1;
uint ui = 1;
ushort us = 1;
byte b = 1;

ul = ui;
ul = us;
ul = b;
ui = us;
ui = b;
us = b;

//浮点数   decimal double float

decimal de = 1.1m;
double d = 1.1;
float f = 1.1f;
//decimal这个类型没有办法用隐式转换的形式去存储double和float
//de = d;de = f;(报错)
//float 是可以隐式转换成double
d = f;
//特殊类型   bool char string
//他们之间不存在隐式转换（彼此之间无关系）

#endregion

#region 知识点二 不同大类型之间的转换

#region 无符号和有符号之间
//无符号 不能装负数的
byte b2 = 1; //0-255
ushort us2 = 1;
uint ui2 = 1;
ulong ul2 = 1;
//有符号
sbyte sb2 = 1;
short s2 = 1;
int i2 = 1;
long l2 = 1;

//无符号装有符号
//有符号的变量 是不能够 隐式转换成 无符号的
//b2 =sb2;
//us2 = sb2;
//ul2= sb2;

//有符号装无符号
//有符号变量是可以装无符号变量的前提是范围一定要是涵盖的 存在隐式转换
// i2 = ui2;//因为有符号的变量 可能会超过 这个无符号变量的范围
i2 = b2;//因为 有符号的变量 不管是多少 都在 无符号变量的范围内

#endregion

#region 浮点数和整数（有、无符号）之间
//浮点数装整数 整形转为浮点数 是存在隐式转换的
float f2 = 1.1f;
double d2 = 1.1;
decimal de2 = 1.1m;
//浮点数是可以装载任何类型的整数的
f2 = 12;
f2 = i2;
f2 = s2;
f2 = sb2;

f2 = ul2;
f2 = ui2;
f2 = us2;
f2 = b2;

f2 = 1000000000000000000;
Console.WriteLine(f2);

//decimal不能隐式存储float和double
//但是它可以隐式的存储整形
de = 12;
de = ul2;
//double一>float一>所有整形（无符号、有符号）
//decimal一>所有整形（无符号、有符号）

//整数装浮点数
//整数装浮点数 整数是不能隐式存储 浮点数 因为整数不能存小数
//i2=f2;
#endregion

#region 特殊类型和其他类型之间

//boolboo1没有办法和其它类型相互隐式转换
bool bo2 = true;
char c2 = 'A';
string str2 = "1231";
//bo2=i2;
//bo2 =ui2;
//bo2 = f2;

//i2=bo2;
//ui2= bo2;
//f2 =bo2;

//bo2 =c2;
//c2=bo2;
//bo2 = str2;
//str2 =bo2;

//char char 没有办法隐式的存储 其他类型的变量
//c2=i2;
//c2 = f2;
//c2=ui2;
//c2 = str2;

//char可以隐式转为整形,其实是转为了int类型

//然后int类型又隐式转换为其它可转换的类型
//所以对于
//short、byte等存储范围小于int的类型
//无法表现为隐式转换
//char隐式转换成 数值类型是
//对应的数字 其实是一个 ASCII码
//计算机里面存储 2进制
//字符 中文 英文 标点符号 在计算机中都是一个数字
//一个字符 对应一个数字 ASII码就是一种对应关系
i2 = c2;
Console.WriteLine(i2);
f2 = c2;
Console.WriteLine(f2);
ui2 = c2;
Console.WriteLine(ui2);

//str2 = c2；

//string 类型 无法和其他类型进行隐式转换

#endregion

#endregion


//总结 隐式转换 规则
//高精度（大范围）装低精度（小范围）
//double一>float一>整数（无符号、有符号）->char
//decima1一>整数（无符号、有符号）一>char
//string 和 bool 不参与隐式转换规则的
// See https://aka.ms/new-console-template for more information
Console.WriteLine("隐式转换练习题");

#region 练习题一
//什么情况下会出现数据类型的隐式转换，请举例说明
//大范围存小范围
//double->float一>整形（无符号、有符号）一>char
//decimal一>整形（无符号、有符号）一>char
//long->int -> short ->sbyte
//ulong-> uint -> ushort -> byte
//无符号 没法 隐式存储 有符号的
//有符号的 可以 隐式存储 无符号（范围大小）

int i=1;
short s = 1;
i = s;


#endregion

#region 练习题二
//请将自己名字的每一个字符转换成数字并打印出来
//char j = '加';
//ASII 码
int jia = '加';
Console.WriteLine(jia);
int lai = '濑';
Console.WriteLine(lai);
int you = '友';
Console.WriteLine(you);
int xiang = '香';
Console.WriteLine(xiang);

Console.WriteLine("加濑友香对应的数字编号："+ jia + lai + you + xiang);

#endregion

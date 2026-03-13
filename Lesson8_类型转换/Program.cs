// See https://aka.ms/new-console-template for more information
Console.WriteLine("类型转换——显示转换");

//显示转换——>手动处理 强制转换

#region 知识点一 括号强转
//作用  一般情况下 将高精度的类型强制转换为低精度
//语法：  变量类型 变量名 =（变量类型）变量；
//注意：  精度问题 范围问题

//相同大类的整形
//有符号整形
sbyte sb = 1;
short s = 1;
int i = 40000;
long l = 1;

//括号强转 可能会出现范围问题 造成的异常
s = (short)i;
Console.WriteLine(s);

i = (int)l;
sb = (sbyte)s;
sb = (sbyte)i;
sb = (sbyte)l;

// 无符号整形
byte b = 1;
uint ui = 1;
b = (byte)ui;

//浮点之间（精度丢失）
float f = 1.1f;
double d = 1.1234567890123456789f;
f = (float)d;
Console.WriteLine(f);

//无符号和有符号
uint ui2 = 1;
int i2 = -1;
//在强转时  一定要注意范围 不然得到的结果 可能有异常
ui2 = (uint)i2;
Console.WriteLine(ui2);

i2 = (int)ui2;


//浮点和整形 浮点数强转成整形时 会直接抛弃掉小数点后面的小数（不会四舍五入）
i2 = (int)1.64f;
Console.WriteLine(i2);

//char和数值类型
i2 = 'A';

char c =（char）i2;
Console.WriteLine(c);
//bool和string 是不能够通过 括号强转的

//bool bo= true;
//int i3 =(bool)bo;
//string str= "123";
//i3 =(int)str;


#endregion

#region 知识点二 Parse法

#endregion

#region 知识点三 Convert法

#endregion

#region 知识点四 其它类型转string

#endregion
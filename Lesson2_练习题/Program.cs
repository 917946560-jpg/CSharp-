// See https://aka.ms/new-console-template for more information
Console.WriteLine("变量相关练习题");
#region 练习题1
//下面代码的输出结果是
double num = 36.6;
//打印一个字符串
Console.WriteLine("num");
//打印变量容器中存储的内容
Console.WriteLine(num);
#endregion
#region 练习题2
//声明float类型变量时，为何要在数字后面加f---不加默认是double类型
float f = 1 / 234f;
#endregion
#region 练习题3
//请定义一系列变量来存储你的名字、年龄、性别、身高、体重、家庭住址等，并打印出来。
string name = "加濑友香";
Console.WriteLine("我的名字是"+name);
byte age = 20;
Console.WriteLine("我的年龄是"+age);
float height = 177.5f;
Console.WriteLine("我的身高是" + height);
float weight = 56.5f;
Console.WriteLine("我的体重是" + weight);
string address = "日本";
Console.WriteLine("我的地址是" + address);
#endregion
#region 练习题4
//小明的数学考试成绩是80，语文的考试成绩是78，英语的考试成绩是98，请用变量描述并打印
byte math = 80;
byte Chinese = 78;
byte English = 98;
Console.WriteLine("我的数学成绩是：" + math);
Console.WriteLine("我的国文成绩是：" + Chinese);
Console.WriteLine("我的英语成绩是：" + English);
#endregion


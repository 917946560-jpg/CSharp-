// See https://aka.ms/new-console-template for more information
Console.WriteLine("常量");

#region 知识点一 常量的申明
//关键字const
//固定写法：
//const 变量类型 变量名 = 初始值;
//变量的申明
const int i2 = 20;

#endregion

#region 知识点二 常量的特点
//1.必须初始化
//2.不能被修改

//变量申明可以不初始化
string name;
//之后可以修改
name = "123";

const string myName = "加濑友香";
//作用：申明一些常用不变的变量

//PI 3.1415926
const float PI = 3.1415926f;
//可以打印，也可以用来计算



#endregion

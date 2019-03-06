# CSharp_HelloWorld
C# 课程作业2

### 1. 创建新的类，实例化 HelloWorld

![](https://raw.githubusercontent.com/8qwe24657913/CSharp_HelloWorld/master/Images/instance.png)

可通过启动参数指定要问候的人，人名颜色随机

使用反射获取 `ConsoleColor` 类中的所有颜色并随机，若与背景色相同，则修改背景色（见下图），另一种思路是从颜色列表中去除背景色或抽到背景色重新随机，这里没有采用

### 2. 创建新的类，静态方法，无需实例化的 HelloWorld

![](https://raw.githubusercontent.com/8qwe24657913/CSharp_HelloWorld/master/Images/static.gif)

手动动画（不

其中有些名字是白色背景，因为抽到了黑色前景色，与原背景色相同

### 3. WPF 的 HelloWorld

![](https://raw.githubusercontent.com/8qwe24657913/CSharp_HelloWorld/master/Images/WPF.png)

用 `ListView` 显示命令行参数的程序

踩到的一个坑是数据绑定必须是 `param` 而不能是 `field` ，否则读取不到。然而我并没有在微软官方文档中找到相关介绍……

### 4. WindowsForm 中创建新类的 HelloWorld

![](https://raw.githubusercontent.com/8qwe24657913/CSharp_HelloWorld/master/Images/winform.png)

同上，但使用 WindowsForm 创建新类完成

### 5. Xamarin Android HelloWorld

![](https://raw.githubusercontent.com/8qwe24657913/CSharp_HelloWorld/master/Images/xamarin.png)

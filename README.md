# CSharpTipCalculator

C# 课程作业3 - 小费计算器

## 作业要求

仿照视频中的小费计算器自制一个

## 功能描述

输入账单价格，选择小费的百分比，显示小费金额和总金额

## 运行截图

![](https://raw.githubusercontent.com/8qwe24657913/CSharpTipCalculator/master/images/sample.png)

## 附录

视频中用 `double` 计算钱数，可能带来计算不精确的 bug

![](https://raw.githubusercontent.com/8qwe24657913/CSharpTipCalculator/master/images/bug.png)

然而我并没有找到 C# 中 与 Java 的 `BigDecimal` 功能类似的类。一般迂回的话应该用转成 `long` 计算，但考虑到用户输入没有任何限制，自己解析本应由 `Double.Parse()` 解析的格式较为困难，姑且用 `decimal` 类型代替 `double` 类型以期获得更高精度了（

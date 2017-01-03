# pjsua2-csharp

[![Codacy Badge](https://api.codacy.com/project/badge/Grade/313a8b079c0540cc9d66f80a721c12e7)](https://www.codacy.com/app/liushuixingyun/pjsua2-csharp?utm_source=github.com&utm_medium=referral&utm_content=liushuixingyun/pjsua2-csharp&utm_campaign=badger)

该项目旨在为[pjsip]项目提供`CSharp`语言和`dotNET`环境可调用的库。
它使用了[pjsip]项目官方[swig]接口定义生成的`C/C++`和`CSharp` Wrapper源代码。

## 安装
如果已经获得了`c++`部分的预编译包，可使用[nuget]安装其`c#`部分的项目依赖。
它的[nuget]地址时：https://www.nuget.org/packages/pjsua2-swig-csharp/

否则，应直接从版本库克隆后，编译使用。

## 使用
请参照[pjsip]的`c++`API手册。

目前，[pjsip]官方提供的[swig]方案是针对`Java`和`Python`语言的，但是并没有提供专门针对这些语言的API手册(`Python`版本提供了一个早期非[swig]技术的API手册)。
不过，由于[swig]的接口定义与[pjsip]的`C++`接口高度一致，`CSharp`开发者可参考其`C++`头文件代码以及`API`手册进行开发，见：

<http://www.pjsip.org/docs/book-latest/html/index.html>

我们的另外一个开源项目[oneyun-sipclient-windows](https://github.com/liushuixingyun/oneyun-sipclient-windows)可作为这个类库的使用范例。

[pjsip]: http://www.pjsip.org/
[swig]: http://http://www.swig.org/
[nuget]: http://www.nuget.org

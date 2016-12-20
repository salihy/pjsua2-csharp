# pjsua2-csharp
该项目旨在为[pjsip]项目提供`CSharp`语言和`dotNET`环境可调用的库。
它使用了[pjsip]项目官方[swig]接口定义生成的`C/C++`和`CSharp` Wrapper源代码。

目前，[pjsip]官方提供的[swig]方案是针对`Java`和`Python`语言的，但是并没有提供专门针对这些语言的API手册(`Python`版本提供了一个早期非[swig]技术的API手册)。

不过，由于[swig]的接口定义与[pjsip]的`C++`接口高度一致，`CSharp`开发者可参考其`C++`头文件代码以及`API`手册进行开发，见：

<http://www.pjsip.org/docs/book-latest/html/index.html>

[pjsip]: http://www.pjsip.org/
[swig]: http://http://www.swig.org/

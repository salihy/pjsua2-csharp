# pjsua2-charp
该项目旨在为 [pjsip] 项目提供`CSharp`语言和`dotNET`环境可调用的库。

它通过 [pjsip] 项目官方的 [swig] 接口定义生成 wrapper 的 C/C++ 源代码，以及 dotNET 类库的 CSharp 源代码。

**
CSharp 开发者可以在本代码库中 `pj` CSharp dotNET Library 项目的基础上，构建 `SIP Client`
**

目前，[pjsip]官方提供的[swig]方案是针对`Java`和`Python`的，但是并为提供专门针对这些语言的API手册(`Python`版本提供了一个早期非[swig]技术的API手册)。

不过，由于该[swig]的接口定义与[pjsip]的`C++`接口高度一致，`CSharp`开发者可参考其`C++`头文件代码以及`API`手册进行开发，见：

<http://www.pjsip.org/docs/book-latest/html/index.html>

[pjsip]: http://www.pjsip.org/
[swig]: http://http://www.swig.org/

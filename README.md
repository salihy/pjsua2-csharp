# pjsua2-charp
该项目旨在将 [pjsip] 项目转化为 CSharp 语言可调用的库。

它通过 [pjsip] 项目官方的 [swig] 接口定义生成 wrapper 的 C/C++ 源代码，以及 dotNET 类库的 CSharp 源代码。

## 编译 [pjsip]
按照官方指导，使用 VisualStudio 编译 [pjsip]

## 安装 [swig]
安装 [swig] ，并将 [swig] 的执行命令行所在目录加入到操作系统的 `PATH` 环境变量。

## 生成 wrapper 代码
在命令行中定位到项目目录，然后执行：
```bat
mkdir -p pjsip-apps\src\swig\csharp
cd pjsip\include
swig -csharp -namespace pj -c++ -outdir ..\..\pjsip-apps\src\swig\csharp\ ..\..\pjsip-apps\src\swig\pjsua2.i
```

[swig] 输出的wrapper和类库源文件是：
```
pjsip-apps\src\swig\pjsua2_wrap.h
pjsip-apps\src\swig\pjsua2_wrap.cxx
```

```
pjsip-apps\src\swig\csharp\*.cs
```

## 构建
打开 VisualStudio，建立空解决方案 `pjsua2-charp`。

### VC++ Wrapper 项目

1. 将[pjsip]的项目目录改名为 `pjproject` (去掉版本号)，复制到解决方案目录。
2. 在解决方案中新建名为 `pjsua2` 的 `Win32` 项目，类型是 `DLL`，**不要**选择预编译头和SDL安全检查选项。
3. 将文件`..\..\pjproject\pjsip-apps\src\swig\pjsua2_wrap.h` 加入到该项目的头文件。
4. 将文件`..\..\pjproject\pjsip-apps\src\swig\pjsua2_wrap.cxx` 加入到该项目的源文件。
4. 按照[pjsip]的开发文档，视改项目作普通的使用[pjsip]库的C++项目，进行配置，并编译。

项目的include目录是：
```
$(ProjectDir)../pjproject/pjlib/include;$(ProjectDir)../pjproject/pjlib-util/include;$(ProjectDir)../pjproject/pjnath/include;$(ProjectDir)../pjproject/pjmedia/include;$(ProjectDir)../pjproject/pjsip/include;%(AdditionalIncludeDirectories)
```

库搜索目录是：
```
$(ProjectDir)../pjproject/lib;%(AdditionalLibraryDirectories)
```

额外依赖依赖库有
```
wsock32.lib;ws2_32.lib;dsound.lib;%(AdditionalDependencies)
```

如果出现 `error LNK2038` ，注意在项目属性中 “配置属性”/“C/C++”/“代码生成”/“运行库” 的值设置成与 [pjsip] 项目配置一致。

### 构建 pjproject C# 项目
1. 新建 C# 类库项目 `pj` 
2. 删除项目源文件 `pj.cs`
3. 将 csharp/*.cs 复制到项目目录，然后加入到项目
4. 编译

某些版本的swig产生的cs文件有错， 一些`char`常量没有被单引号包括，故编译错误——需要手动修复！

## API 手册
目前，[pjsip]官方提供的[swig]方案是针对`Java`和`Python`的，但是并为提供专门针对这些语言的API手册（`Python`版本提供了一个早期非[swig]技术的API手册）。

不过，由于该[swig]的接口定义与[pjsip]的`C++`接口高度一致，开发者可参考其`C++`头文件代码以及API手册进行开发，见：

<http://www.pjsip.org/docs/book-latest/html/index.html>


[pjsip]: http://www.pjsip.org/
[swig]: http://http://www.swig.org/

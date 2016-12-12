# CONTRIBUTING

注意：
> 本项目的代码 **不是** 源自此项目的代码提交者，而是来自于[pjsip]项目，以及它通过[swig]工具自动生成的代码。
> 
> 所以，本文记录了这个项目如何产生、如何构建，而不介绍它的编程思想和架构。

## 安装 [swig]
安装[swig]，并将[swig]的执行命令行所在目录加入到操作系统的`PATH`环境变量。

## 编译 [pjsip]
按照官方指导，使用 VisualStudio 编译[pjsip]项目

## 生成 Wrapper 代码
在命令行中定位到项目目录，然后执行：
```bat
mkdir -p pjsip-apps\src\swig\csharp
cd pjsip\include
swig -csharp -namespace pj -c++ -outdir ..\..\pjsip-apps\src\swig\csharp\ ..\..\pjsip-apps\src\swig\pjsua2.i
```

[swig]输出的wrapper和类库源文件是：
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
将[swig]生成的 C/C++ 代码编译成便于 CSharp Interop 访问的原生动态库，此动态库链接了[pjsip]。

1. 将[pjsip]的项目目录改名为`pjproject`(去掉版本号)，复制到解决方案目录。
2. 在解决方案中新建名为`pjsua2`的`Win32`项目，类型是`DLL`，**不要**选择预编译头和SDL安全检查选项。
3. 将文件`..\..\pjproject\pjsip-apps\src\swig\pjsua2_wrap.h` 加入到该项目的头文件。
4. 将文件`..\..\pjproject\pjsip-apps\src\swig\pjsua2_wrap.cxx` 加入到该项目的源文件。
5. 按照[pjsip]的开发文档，将该项目作视普通的使用[pjsip]库的C++项目，进行配置，并编译。

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
libpjproject-i386-<arch>-<vc-version>-<Debug|Release>.lib;wsock32.lib;ws2_32.lib;dsound.lib;%(AdditionalDependencies)
```

如果出现`error LNK2038`，注意在项目属性中 “配置属性”/“C/C++”/“代码生成”/“运行库” 的设置成与[pjsip]项目的配置须保持一致。

### CSharp Interop 项目
将[swig]生成的 CSharp 代码编译成 dotNet 库，此库通过 Interop 方式访问上个项目生成的原生动态库。

1. 新建CSharp类库项目`pj` 
2. 删除项目源文件`pj.cs`
3. 将源文件`pjproject/pjsip-apps/src/swig/csharp/*.cs`加入到项目
4. 编译

某些版本的swig产生的cs文件有错，文件`pjmedia_format_iud.cs`和`pjmedia_event_type.cs`中`Char`常量没有被单引号包括，故编译错误——需要手动修复！

## API 手册
目前，[pjsip]官方提供的[swig]方案仅针对`Java`和`Python`语言，且未提供专门针对这些语言的API手册（`Python`版本提供了一个早期非[swig]技术的API手册）。

不过，由于[swig]的接口定义与`C++`接口高度一致，开发者可参考其`C++`头文件代码以及API手册进行开发，见：

<http://www.pjsip.org/docs/book-latest/html/index.html>

[pjsip]: http://www.pjsip.org/
[swig]: http://http://www.swig.org/

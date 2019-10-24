# rnd-nullable-live-testing

Demo of broken _Live Unit Testing_ feature in Visual Studio 2019 (latest test with 16.4.0 Preview 2).

## Problem description

File `LiveLib/Class1.cs` contains code which requires `<Nullable>enable</Nullable>` in the `*.csproj` to compile.

Manual testing works.

Live Unit Testing fails to compile the source code with these messages:

```txt
LiveLib\Class1.cs(7,17): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
LiveLib\Class1.cs(7,16): error CS8627: A nullable type parameter must be known to be a value type or non-nullable reference type. Consider adding a 'class', 'struct', or type constraint.
```

See problem reported on [developercommunity.visualstudio.com](https://developercommunity.visualstudio.com/content/problem/583431/live-unit-testing-does-not-inherit-project-level-n.html).

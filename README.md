# C# 12 Features - Sample Projects

This repository contains examples of the new features introduced in **C# version 12** (shipped with .NET 8). Each project demonstrates a specific feature, with code you can build and run.

---

## New Features in C# 12 (as illustrated in this repo)

### P187_PrimaryConstructors
- **What’s new**: You can now declare constructor parameters directly in class or struct definitions (not just records).  
- **Example**:
  ```csharp
  public class Person(string name, int age)
  {
      public string Name { get; } = name;
      public int Age { get; } = age;
  }
  ```

---

### P188_CollectionExpressions
- **What’s new**: Use `[...]` to create arrays or collections, with `..` to spread existing collections inside.  
- **Example**:
  ```csharp
  int[] arr = [1, 2, 3];
  int[] arr2 = [0, ..arr, 4];  // => [0,1,2,3,4]
  ```

---

### P189_DefaultLambdaParameters
- **What’s new**: Lambda expressions can define parameters with default values.  
- **Example**:
  ```csharp
  var greet = (string name = "World") => $"Hello {name}!";
  Console.WriteLine(greet());       // Hello World!
  Console.WriteLine(greet("C#"));   // Hello C#!
  ```

---

### P190_UsingAliasAnyType
- **What’s new**: `using` alias directives can now alias any type, including tuples, arrays, and pointers.  
- **Example**:
  ```csharp
  using MyTuple = (int id, string name);
  MyTuple t = (1, "Alice");
  ```

---

### P191_InlineArrays
- **What’s new**: Fixed‑size buffers via `[System.Runtime.CompilerServices.InlineArray(N)]`.  
- **Example**:
  ```csharp
  [System.Runtime.CompilerServices.InlineArray(5)]
  struct Buffer
  {
      private int _element;
  }
  ```

---

### P192_ParamsAndCollections
- **What’s new**: You can mix `params` with collection expressions for more concise APIs.  
- **Example**:
  ```csharp
  void Print(params int[] values)
  {
      foreach (var v in values) Console.WriteLine(v);
  }

  Print(..new[]{1,2,3}, 4, 5);
  ```

---

### P193_PrimaryCtorInitUsage
- **What’s new**: Combine primary constructors with `init` properties and base calls.  

---

### P194_LambdaImprovements
- **What’s new**: Lambdas can now explicitly specify return types, and support more parameter features.  
- **Example**:
  ```csharp
  var square = int (int x) => x * x;
  ```

---

### P195_ExperimentalAttribute
- **What’s new**: APIs can be marked experimental with `[Experimental("id")]`, warning callers.  
- **Example**:
  ```csharp
  [System.Diagnostics.CodeAnalysis.Experimental("EXP001")]
  void NewFeature() { }
  ```

---

### P196_Interceptors_Preview
- **What’s new**: A preview feature that allows method interception (experimental).  

---

### P197_RefReadonlyParameters
- **What’s new**: Methods can take parameters as `ref readonly`, passed by reference but not modifiable.  
- **Example**:
  ```csharp
  void Print(ref readonly int x)
  {
      Console.WriteLine(x);
  }
  ```

---

## Repository Structure

- **Solution**: `CSharpV120_Features_FULL.sln`  
- **Projects**:
  - P187_PrimaryConstructors  
  - P188_CollectionExpressions  
  - P189_DefaultLambdaParameters  
  - P190_UsingAliasAnyType  
  - P191_InlineArrays  
  - P192_ParamsAndCollections  
  - P193_PrimaryCtorInitUsage  
  - P194_LambdaImprovements  
  - P195_ExperimentalAttribute  
  - P196_Interceptors_Preview  
  - P197_RefReadonlyParameters  

---

## Requirements

- .NET 8 SDK  
- C# 12 language version enabled  

To run a sample:
```bash
cd P183_PrimaryConstructors
dotnet run
```

---

## References

- [What’s new in C# 12 – Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)  
- [Announcing C# 12 – .NET Blog](https://devblogs.microsoft.com/dotnet/announcing-csharp-12/)  

# C# 12 Features – Sample Projects

This repository contains examples of the new features introduced in **C# version 12** (shipped with .NET 8). Each project demonstrates a specific feature, with code you can build and run.

---

## 🚀 New Features in C# 12 (as illustrated in this repo)

### 1. Primary Constructors (`P183_PrimaryConstructors`)
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

### 2. Collection Expressions with Spread (`P184_CollectionExpressions`)
- **What’s new**: Use `[...]` to create arrays or collections, with `..` to spread existing collections inside.  
- **Example**:
  ```csharp
  int[] arr = [1, 2, 3];
  int[] arr2 = [0, ..arr, 4];  // => [0,1,2,3,4]
  ```

---

### 3. Default Lambda Parameters (`P185_DefaultLambdaParameters`)
- **What’s new**: Lambda expressions can define parameters with default values.  
- **Example**:
  ```csharp
  var greet = (string name = "World") => $"Hello {name}!";
  Console.WriteLine(greet());       // Hello World!
  Console.WriteLine(greet("C#"));   // Hello C#!
  ```

---

### 4. Using Alias for Any Type (`P186_UsingAliasAnyType`)
- **What’s new**: `using` alias directives can now alias any type, including tuples, arrays, and pointers.  
- **Example**:
  ```csharp
  using MyTuple = (int id, string name);
  MyTuple t = (1, "Alice");
  ```

---

### 5. Inline Arrays (`P187_InlineArrays`)
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

### 6. Params with Collections (`P188_ParamsAndCollections`)
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

### 7. Primary Constructor with Init Usage (`P189_PrimaryCtorInitUsage`)
- **What’s new**: Combine primary constructors with `init` properties and base calls.  

---

### 8. Lambda Improvements (`P190_LambdaImprovements`)
- **What’s new**: Lambdas can now explicitly specify return types, and support more parameter features.  
- **Example**:
  ```csharp
  var square = int (int x) => x * x;
  ```

---

### 9. ExperimentalAttribute (`P191_ExperimentalAttribute`)
- **What’s new**: APIs can be marked experimental with `[Experimental("id")]`, warning callers.  
- **Example**:
  ```csharp
  [System.Diagnostics.CodeAnalysis.Experimental("EXP001")]
  void NewFeature() { }
  ```

---

### 10. Interceptors (Preview) (`P192_Interceptors_Preview`)
- **What’s new**: A preview feature that allows method interception (experimental).  

---

### 11. Ref Readonly Parameters (`P193_RefReadonlyParameters`)
- **What’s new**: Methods can take parameters as `ref readonly`, passed by reference but not modifiable.  
- **Example**:
  ```csharp
  void Print(ref readonly int x)
  {
      Console.WriteLine(x);
  }
  ```

---

## 📂 Repository Structure

- **Solution**: `CSharpV120_Features_FULL.sln`  
- **Projects**:
  - P183_PrimaryConstructors  
  - P184_CollectionExpressions  
  - P185_DefaultLambdaParameters  
  - P186_UsingAliasAnyType  
  - P187_InlineArrays  
  - P188_ParamsAndCollections  
  - P189_PrimaryCtorInitUsage  
  - P190_LambdaImprovements  
  - P191_ExperimentalAttribute  
  - P192_Interceptors_Preview  
  - P193_RefReadonlyParameters  

---

## 🔧 Requirements

- .NET 8 SDK  
- C# 12 language version enabled  

To run a sample:
```bash
cd P183_PrimaryConstructors
dotnet run
```

---

## 📖 References

- [What’s new in C# 12 – Microsoft Docs](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)  
- [Announcing C# 12 – .NET Blog](https://devblogs.microsoft.com/dotnet/announcing-csharp-12/)  

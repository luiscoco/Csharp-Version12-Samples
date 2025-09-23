# C# 12.0 Features (VS 2022 / .NET 8)

This solution bundles **core C# 12 features** plus extras (ExperimentalAttribute, Interceptors - preview, Ref readonly params).

## Projects
P183_PrimaryConstructors — Primary constructors (class/struct).
P184_CollectionExpressions — Collection expressions with spread.
P185_DefaultLambdaParameters — Default parameter values in lambdas.
P186_UsingAliasAnyType — using-alias for tuples/arrays.
P187_InlineArrays — [InlineArray(N)] fixed-size buffers.
P188_ParamsAndCollections — Collection expressions + params.
P189_PrimaryCtorInitUsage — Primary ctor with base call & init from params.
P190_LambdaImprovements — Lambda explicit return type with span parameter.
P191_ExperimentalAttribute — Mark API experimental and use it.
P192_Interceptors_Preview — Preview-only interceptors attribute illustration.
P193_RefReadonlyParameters — ref readonly parameters, call with 'in'.

## Build & Run
dotnet restore
dotnet build
dotnet run --project P183_PrimaryConstructors

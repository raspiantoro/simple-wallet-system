# Simple Wallet System

This repository contains the source code examples from the article **[Make the C# Compiler Tell You What You Forgot](https://medium.com/@marioraspiantoro/make-the-c-compiler-tell-you-what-you-forgot-805247221e77)**.

The examples demonstrate how C# union types can help model a fixed set of wallet transaction types and allow the compiler to detect missing cases in pattern matching.

## Requirements

- [.NET 11 SDK](https://dotnet.microsoft.com/download/dotnet/11.0)
- C# 15

The project targets `net11.0` and uses C# 15 union types.

## Running the Example

Clone the repository:

```bash
git clone https://github.com/raspiantoro/simple-wallet-system.git
cd simple-wallet-system
```

Run the application:

```bash
dotnet run
```

## License

This project is licensed under the [MIT License](LICENSE).
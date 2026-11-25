# TorBox C# SDK

.NET 10 client for the [TorBox API](https://api-docs.torbox.app).

```bash
dotnet add package TorBox.Sdk --version 9.3.2026112508
```

```csharp
using TorBox.Sdk;
using TorBox.Sdk.Api;

using var client = new TorBoxClient(Environment.GetEnvironmentVariable("TORBOX_API_KEY")
    ?? throw new InvalidOperationException("Set TORBOX_API_KEY."));

var response = (await client.Api<IUserApi>().GetUserDataAsync()).Ok();
if (response is not { Success: true })
    throw new InvalidOperationException(response?.Detail ?? "Get User Data failed.");
Console.WriteLine(response.Data);
```

The generated methods expose the HTTP status and TorBox response envelope. For download links, pass `client.ApiKey`
as the `token` argument. File uploads accept a `FileParameter` with a stream and filename. The generated API groups
also work with dependency injection via `AddApi`.

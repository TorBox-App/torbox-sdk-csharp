using System;
using Microsoft.Extensions.DependencyInjection;
using TorBox.Sdk.Client;
using TorBox.Sdk.Extensions;

namespace TorBox.Sdk;

/// <summary>Configures generated TorBox API groups with a per-client bearer key.</summary>
public sealed class TorBoxClient : IDisposable
{
    private readonly ServiceProvider services;

    /// <summary>The API key used by this client. Download link methods take it as a query parameter.</summary>
    public string ApiKey { get; }

    /// <summary>Creates a client for the TorBox API.</summary>
    public TorBoxClient(string apiKey, string baseUrl = "https://api.torbox.app")
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        ApiKey = apiKey;
        var address = new Uri(baseUrl.TrimEnd('/') + "/", UriKind.Absolute);
        var collection = new ServiceCollection();
        collection.AddApi(options =>
        {
            options.AddTokens(new BearerToken(apiKey));
            options.AddApiHttpClients(client =>
            {
                client.BaseAddress = address;
                client.Timeout = TimeSpan.FromSeconds(30);
            });
        });
        services = collection.BuildServiceProvider();
    }

    /// <summary>Gets a generated API group such as <see cref="Api.IUserApi"/>.</summary>
    public T Api<T>() where T : notnull => services.GetRequiredService<T>();

    /// <inheritdoc />
    public void Dispose() => services.Dispose();
}

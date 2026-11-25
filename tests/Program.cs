using System.Text;
using TorBox.Sdk;
using TorBox.Sdk.Api;
using TorBox.Sdk.Client;

var mock = Environment.GetEnvironmentVariable("TORBOX_MOCK_URL")
    ?? throw new InvalidOperationException("TORBOX_MOCK_URL is required.");
using var client = new TorBoxClient("torbox-sdk-test", mock);

var account = (await client.Api<IUserApi>().GetUserDataAsync()).Ok();
if (account is not { Success: true, Data: not null })
    throw new InvalidOperationException("User data request failed.");

var torrents = client.Api<ITorrentsApi>();
using var file = new MemoryStream(Encoding.ASCII.GetBytes("d8:announce0:e"));
// A space makes .NET quote the filename, which Prism's multipart parser requires.
var upload = (await torrents.CreateTorrentAsync(file: new FileParameter(file, "test upload.torrent"))).Ok();
if (upload is not { Success: true })
    throw new InvalidOperationException("Torrent upload failed.");

var magnet = (await torrents.CreateTorrentAsync(
    file: (FileParameter?)null,
    magnet: "magnet:?xt=urn:btih:0123456789012345678901234567890123456789")).Ok();
if (magnet is not { Success: true })
    throw new InvalidOperationException("Magnet submission failed.");

var download = (await torrents.RequestTorrentDownloadLinkAsync(client.ApiKey, 1, 0L)).Ok();
if (download is not { Success: true })
    throw new InvalidOperationException("Download link request failed.");

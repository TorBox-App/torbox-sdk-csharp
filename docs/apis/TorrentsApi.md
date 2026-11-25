# TorBox.Sdk.Api.TorrentsApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AsyncCreateTorrent**](TorrentsApi.md#asynccreatetorrent) | **POST** /v1/api/torrents/asynccreatetorrent | Async Create Torrent |
| [**ControlQueuedTorrents**](TorrentsApi.md#controlqueuedtorrents) | **POST** /v1/api/torrents/controlqueued | Control Queued Torrents |
| [**ControlTorrent**](TorrentsApi.md#controltorrent) | **POST** /v1/api/torrents/controltorrent | Control Torrent |
| [**CreateTorrent**](TorrentsApi.md#createtorrent) | **POST** /v1/api/torrents/createtorrent | Create Torrent |
| [**EditTorrentItem**](TorrentsApi.md#edittorrentitem) | **PUT** /v1/api/torrents/edittorrent | Edit Torrent Item |
| [**ExportTorrentData**](TorrentsApi.md#exporttorrentdata) | **GET** /v1/api/torrents/exportdata | Export Torrent Data |
| [**GetQueuedTorrents**](TorrentsApi.md#getqueuedtorrents) | **GET** /v1/api/torrents/getqueued | Get Queued Torrents |
| [**GetTorrentCachedAvailability**](TorrentsApi.md#gettorrentcachedavailability) | **GET** /v1/api/torrents/checkcached | Get Torrent Cached Availability |
| [**GetTorrentCachedAvailabilityBatch**](TorrentsApi.md#gettorrentcachedavailabilitybatch) | **POST** /v1/api/torrents/checkcached | Get Torrent Cached Availability Batch |
| [**GetTorrentInfo**](TorrentsApi.md#gettorrentinfo) | **GET** /v1/api/torrents/torrentinfo | Get Torrent Info |
| [**GetTorrentInfoFromFile**](TorrentsApi.md#gettorrentinfofromfile) | **POST** /v1/api/torrents/torrentinfo | Get Torrent Info |
| [**GetTorrentList**](TorrentsApi.md#gettorrentlist) | **GET** /v1/api/torrents/mylist | Get Torrent List |
| [**MagnetToFile**](TorrentsApi.md#magnettofile) | **POST** /v1/api/torrents/magnettofile | Magnet To File |
| [**RequestTorrentDownloadLink**](TorrentsApi.md#requesttorrentdownloadlink) | **GET** /v1/api/torrents/requestdl | Request Download Link |
| [**RequestTorrentDownloadLinksGet**](TorrentsApi.md#requesttorrentdownloadlinksget) | **GET** /v1/api/torrents/requestdl/batch | Request Download Links - GET |
| [**RequestTorrentDownloadLinksPost**](TorrentsApi.md#requesttorrentdownloadlinkspost) | **POST** /v1/api/torrents/requestdl/batch | Request Download Links - POST |

<a id="asynccreatetorrent"></a>
# **AsyncCreateTorrent**
> AsyncCreateTorrentResponse AsyncCreateTorrent (System.IO.Stream file = null, string magnet = null, long seed = null, bool allowZip = null, string name = null, bool asQueued = null, bool addOnlyIfCached = null)

Async Create Torrent

### Overview  Creates a torrent asynchrously under your account. Simply send **either** a magnet link, or a torrent file. Once they have been checked, they will begin downloading assuming your account has available active download slots, and they aren't too large.  The request will return instantly, not returning any data other than a success message. This is the same for failures, as they will return the error in the background, rather than immediately.  ### Rate Limits  This endpoint has the same limits as the Create Torrent endpoint: **300 requests per minute**, and **60 uncached torrents per hour**. The hourly limit is shared between the two endpoints, so an uncached torrent added through either one counts against the same 60. As on that endpoint, a request sent with `add_only_if_cached` and without `as_queued` is not counted against the hourly limit.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | The torrent&#39;s torrent file. Optional. | [optional]  |
| **magnet** | **string** | The torrent&#39;s magnet link. Optional. | [optional]  |
| **seed** | **long** | Tells TorBox your preference for seeding this torrent. 1 is auto. 2 is seed. 3 is don&#39;t seed. Optional. Default is 1, or whatever the user has in their settings. Overwrites option in settings. | [optional]  |
| **allowZip** | **bool** | Tells TorBox if you want to allow this torrent to be zipped or not. TorBox only zips if the torrent is 100 files or larger. | [optional] [default to true] |
| **name** | **string** | The name you want the torrent to be. Optional. | [optional]  |
| **asQueued** | **bool** | Tells TorBox you want this torrent instantly queued. This is bypassed if user is on free plan, and will process the request as normal in this case. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**AsyncCreateTorrentResponse**](AsyncCreateTorrentResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="controlqueuedtorrents"></a>
# **ControlQueuedTorrents**
> void ControlQueuedTorrents ()

Control Queued Torrents

### Overview  This endpoint is deprecated and always answers with a `DEPRECATED` error. Use the Control Queued Downloads endpoint (`/v1/api/queued/controlqueued`) instead.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **410** | Gone |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="controltorrent"></a>
# **ControlTorrent**
> ControlTorrentResponse ControlTorrent (ControlTorrent controlTorrent)

Control Torrent

### Overview  Controls a torrent. By sending the torrent's ID and the type of operation you want to perform, it will send that request to the torrent client.  Operations are either:  - **Reannounce** `reannounces the torrent to get new peers`  - **Delete** `deletes the torrent from the client and your account permanently`  - **Resume** `resumes a paused torrent`   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **controlTorrent** | [**ControlTorrent**](ControlTorrent.md) |  |  |

### Return type

[**ControlTorrentResponse**](ControlTorrentResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createtorrent"></a>
# **CreateTorrent**
> CreateTorrentResponse CreateTorrent (System.IO.Stream file = null, string magnet = null, long seed = null, bool allowZip = null, string name = null, bool asQueued = null, bool addOnlyIfCached = null)

Create Torrent

### Overview  Creates a torrent under your account. Simply send **either** a magnet link, or a torrent file. Once they have been checked, they will begin downloading assuming your account has available active download slots, and they aren't too large.  ### Rate Limits  This endpoint has two limits that apply at the same time:  - **300 requests per minute:** a shared ceiling that _every_ request counts against, whether the torrent is cached or uncached.  - **60 uncached torrents per hour:** an additional, stricter limit that only uncached torrents count against. A request sent with `add_only_if_cached` is not counted, because it adds nothing when the torrent is not cached. It is counted when it is also sent with `as_queued`, because a queued torrent is added whether it is cached or not.   The important thing is that cached and uncached requests both draw from the same 300/min pool, but uncached requests _also_ draw from their own separate 60/hour pool. An uncached request therefore counts twice: once against the per-minute limit, and once against the per-hour uncached limit.  **Example:** In a single minute you add 250 cached + 50 uncached torrents. That's 300 total, so you've hit the per-minute limit for that minute. But those 50 uncached torrents also came out of your 60/hour uncached budget, leaving only **10 uncached torrents** for the remaining 59 minutes of that hour. (You could still add plenty more _cached_ torrents during that hour, since cached requests aren't capped hourly: only by the 300/min ceiling.)  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** | The torrent&#39;s torrent file. Optional. | [optional]  |
| **magnet** | **string** | The torrent&#39;s magnet link. Optional. | [optional]  |
| **seed** | **long** | Tells TorBox your preference for seeding this torrent. 1 is auto. 2 is seed. 3 is don&#39;t seed. Optional. Default is 1, or whatever the user has in their settings. Overwrites option in settings. | [optional]  |
| **allowZip** | **bool** | Tells TorBox if you want to allow this torrent to be zipped or not. TorBox only zips if the torrent is 100 files or larger. | [optional] [default to true] |
| **name** | **string** | The name you want the torrent to be. Optional. | [optional]  |
| **asQueued** | **bool** | Tells TorBox you want this torrent instantly queued. This is bypassed if user is on free plan, and will process the request as normal in this case. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**CreateTorrentResponse**](CreateTorrentResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="edittorrentitem"></a>
# **EditTorrentItem**
> EditTorrentItemResponse EditTorrentItem (EditTorrent editTorrent)

Edit Torrent Item

### Overview  Updates a download item based on the item's ID. Sending a PUT request with valid items overwrites the previous items entirely, so use this endpoint with caution. Please make sure to read the restrictions below as they are important.  ### Restrictions  - Does not affect the cached database (or any other user's item).  - Name must pass validation:      - Above 1 character long.      - Below 200 characters long.      - Cannot contain any non-url or non filesystem safe characters. (This is removed automatically).      - Cannot contain any leading or trailing whitespace. You can have spaces in the middle. (This is removed automatically).  - Tags follow the same rules as the name.  - Alternative hashes must be of MD5, SHA1, or SHA256.   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **editTorrent** | [**EditTorrent**](EditTorrent.md) |  |  |

### Return type

[**EditTorrentItemResponse**](EditTorrentItemResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exporttorrentdata"></a>
# **ExportTorrentData**
> ExportTorrentDataResponse ExportTorrentData (long torrentId, string type)

Export Torrent Data

### Overview  Exports the magnet or torrent file. Requires a type to be passed. If type is **magnet**, it will return a JSON response with the magnet as a string in the _data_ key. If type is **file**, it will return a bittorrent file as a download. Not compatible with cached downloads.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **torrentId** | **long** | The torrent&#39;s ID. |  |
| **type** | **string** | Either \&quot;magnet\&quot; or \&quot;file\&quot;. Tells how the API what to get, and what to respond as. If magnet, it returns a JSON response with the magnet as a string in the data key. If file, it responds with a torrent file download. |  |

### Return type

[**ExportTorrentDataResponse**](ExportTorrentDataResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/x-bittorrent


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getqueuedtorrents"></a>
# **GetQueuedTorrents**
> void GetQueuedTorrents ()

Get Queued Torrents

### Overview  This endpoint is deprecated and always answers with a `DEPRECATED` error. Use the Get Queued Downloads endpoint (`/v1/api/queued/getqueued`) instead.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | Not Found |  -  |
| **410** | Gone |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettorrentcachedavailability"></a>
# **GetTorrentCachedAvailability**
> GetTorrentCachedAvailabilityResponse GetTorrentCachedAvailability (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Torrent Cached Availability

### Overview  Takes in a list of comma separated torrent hashes and checks if the torrent is cached. This endpoint only gets a max of around 100 at a time, due to http limits in queries. If you want to do more, you can simply do more hash queries. Such as: `?hash=XXXX&hash=XXXX&hash=XXXX`  or `?hash=XXXX,XXXX&hash=XXXX&hash=XXXX,XXXX` and this will work too. Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) | The list of torrent hashes you want to check. Comma seperated. | [optional]  |
| **format** | **string** | Format you want the data in. Acceptable is either \&quot;object\&quot; or \&quot;list\&quot;. List is the most performant option as it doesn&#39;t require modification of the list. | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** | Allows you to list the files found inside the cached data. | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetTorrentCachedAvailabilityResponse**](GetTorrentCachedAvailabilityResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettorrentcachedavailabilitybatch"></a>
# **GetTorrentCachedAvailabilityBatch**
> GetTorrentCachedAvailabilityBatchResponse GetTorrentCachedAvailabilityBatch (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Torrent Cached Availability Batch

### Overview  Takes in a list of comma separated torrent hashes and checks if the torrent is cached. With the POST endpoint you can submit a nearly unlimited hashes compared to the GET endpoint which is limited by url parameters.   Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **format** | **string** |  | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** |  | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetTorrentCachedAvailabilityBatchResponse**](GetTorrentCachedAvailabilityBatchResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettorrentinfo"></a>
# **GetTorrentInfo**
> GetTorrentInfoResponse GetTorrentInfo (string hash, long timeout = null, bool useCacheLookup = null)

Get Torrent Info

### Overview  A general route that allows you to give a hash, and TorBox will return data about the torrent. This data is retrieved from the Bittorrent network, so expect it to take some time. If the request goes longer than 10 seconds, TorBox will cancel it. You can adjust this if you like, but the default is 10 seconds. This route is cached as well, so subsequent requests will be instant.  **It is not recommended to use this for checking TorBox's cache. Please use the GET /checkcache endpoint instead.**  ### Authorization  None required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | **string** | Hash of the torrent you want to get info for. This is required. |  |
| **timeout** | **long** | The amount of time you want TorBox to search for the torrent on the Bittorrent network. If the number of seeders is low or even zero, this value may be helpful to move up. Default is 10. Optional. | [optional] [default to 30] |
| **useCacheLookup** | **bool** | If you want to use a pre-cached request if sent before. This can save a lot of time. Default false. | [optional] [default to false] |

### Return type

[**GetTorrentInfoResponse**](GetTorrentInfoResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettorrentinfofromfile"></a>
# **GetTorrentInfoFromFile**
> GetTorrentInfoFromFileResponse GetTorrentInfoFromFile (long timeout = null, string hash = null, string magnet = null, System.IO.Stream file = null, bool useCacheLookup = null, bool peersOnly = null)

Get Torrent Info

### Overview  Same as the GET route, but allows posting data such as magnet, and torrent files.  Hashes will have precedence over magnets, and magnets will have precedence over torrent files.  Only proper torrent files are accepted.  At least one of hash, magnet, or torrent file is required.  A general route that allows you to give a hash, and TorBox will return data about the torrent. This data is retrieved from the Bittorrent network, so expect it to take some time. If the request goes longer than 10 seconds, TorBox will cancel it. You can adjust this if you like, but the default is 10 seconds. This route is cached as well, so subsequent requests will be instant.  **It is not recommended to use this for checking TorBox's cache. Please use the GET /checkcache endpoint instead.**  ### Authorization  None required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timeout** | **long** | The amount of time you want TorBox to search for the torrent on the Bittorrent network. If the number of seeders is low or even zero, this value may be helpful to move up. Default is 10. Optional. | [optional] [default to 10] |
| **hash** | **string** | A torrent hash for requesting information about the torrent. Optional. | [optional]  |
| **magnet** | **string** | A magnet link for requesting information abouit the torrent. Optional. | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** | A torrent file for requesting information about the torrent. Optional. | [optional]  |
| **useCacheLookup** | **bool** | If you want to use a pre-cached request if sent before. This can save a lot of time. Default false. | [optional] [default to false] |
| **peersOnly** | **bool** | Uses a quick lookup method using the trackers contained within the magnet or file. Requires the submitted magnet or torrent file to contain trackers of UDP or HTTP(S) to work. This will not get metadata such as name, size, or files. Best used for simply and quickly gathering the current seeds and peers according to the trackers. Uses the highest number of all the trackers as the final value. Default off. | [optional] [default to false] |

### Return type

[**GetTorrentInfoFromFileResponse**](GetTorrentInfoFromFileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettorrentlist"></a>
# **GetTorrentList**
> GetTorrentListResponse GetTorrentList (long id = null, bool bypassCache = null, long offset = null, long limit = null, bool files = null, bool active = null)

Get Torrent List

### Overview  Gets the user's torrent list. This gives you the needed information to perform other torrent actions. This information only gets updated every 600 seconds, or when the _Request Update On Torrent_ request is sent to the _relay API_.  #### Download States:  - \"downloading\" -> The torrent is currently downloading.  - \"uploading\" -> The torrent is currently seeding.  - \"stalled (no seeds)\" -> The torrent is trying to download, but there are no seeds connected to download from.  - \"paused\" -> The torrent is paused.  - \"completed\" -> The torrent is completely downloaded. Do not use this for download completion status.  - \"cached\" -> The torrent is cached from the server.  - \"metaDL\" -> The torrent is downloading metadata from the hoard.  - \"checkingResumeData\" -> The torrent is checking resumable data.   All other statuses are basic qBittorrent states. [Check out here for the full list](https://github.com/qbittorrent/qBittorrent/wiki/WebUI-API-(qBittorrent-4.1)#torrent-management).  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Determines the torrent requested, will return an object rather than list. Optional. | [optional]  |
| **bypassCache** | **bool** | Allows you to bypass the cached data, and always get fresh information. Useful if constantly querying for fresh download stats. Otherwise, we request that you save our database a few calls. | [optional] [default to false] |
| **offset** | **long** | Determines the offset of items to get from the database. Default is 0. Optional. | [optional] [default to 0] |
| **limit** | **long** | Determines the number of items to recieve per request. Default is 1000. Optional. | [optional] [default to 1000] |
| **files** | **bool** | Exclude files from response. Optional | [optional] [default to true] |
| **active** | **bool** | Shows only active downloads. Optional | [optional]  |

### Return type

[**GetTorrentListResponse**](GetTorrentListResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="magnettofile"></a>
# **MagnetToFile**
> string MagnetToFile (MagnetToTorrent magnetToTorrent)

Magnet To File

### Overview  Converts any magnet to a torrent file. Does not require the magnet to be on your TorBox account or in the TorBox cache. Free endpoint for public use.  ### Authorization  None required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **magnetToTorrent** | [**MagnetToTorrent**](MagnetToTorrent.md) |  |  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/x-bittorrent, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requesttorrentdownloadlink"></a>
# **RequestTorrentDownloadLink**
> RequestTorrentDownloadLinkResponse RequestTorrentDownloadLink (string token, long torrentId, long fileId = null, bool zipLink = null, string userIp = null, bool redirect = null, bool appendName = null)

Request Download Link

### Overview  Requests the download link from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Permalinks  Instead of generating many CDN urls by requesting this endpoint, you can instead create a permalink such as: `https://api.torbox.app/v1/api/torrents/requestdl?token=APIKEY&torrent_id=NUMBER&file_id=NUMBER&redirect=true` and when a user clicks on it, it will automatically redirect them to the CDN link. This saves requests and doesn't abuse the API. Use this method rather than saving CDN links as they are not permanent. To invalidate these permalinks, simply reset your API token or delete the item from your dashboard.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **torrentId** | **long** | The torrent&#39;s ID that you want to download |  |
| **fileId** | **long** | The files&#39;s ID that you want to download | [optional] [default to 0] |
| **zipLink** | **bool** | If you want a zip link. Required if no file_id. Takes precedence over file_id if both are given. | [optional] [default to false] |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **redirect** | **bool** | If you want to redirect the user to the CDN link. This is useful for creating permalinks so that you can just make this request URL the link. | [optional] [default to false] |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |

### Return type

[**RequestTorrentDownloadLinkResponse**](RequestTorrentDownloadLinkResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **307** | Temporary Redirect |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requesttorrentdownloadlinksget"></a>
# **RequestTorrentDownloadLinksGet**
> RequestTorrentDownloadLinksGetResponse RequestTorrentDownloadLinksGet (string token, long torrentId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - GET

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **torrentId** | **long** | The torrent&#39;s ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) | The files&#39;s ID that you want to download | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestTorrentDownloadLinksGetResponse**](RequestTorrentDownloadLinksGetResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requesttorrentdownloadlinkspost"></a>
# **RequestTorrentDownloadLinksPost**
> RequestTorrentDownloadLinksPostResponse RequestTorrentDownloadLinksPost (string token, long torrentId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - POST

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **torrentId** | **long** | The torrent&#39;s ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) |  | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestTorrentDownloadLinksPostResponse**](RequestTorrentDownloadLinksPostResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


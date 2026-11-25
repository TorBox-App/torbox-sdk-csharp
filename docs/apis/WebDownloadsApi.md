# TorBox.Sdk.Api.WebDownloadsApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AsyncCreateWebDownload**](WebDownloadsApi.md#asynccreatewebdownload) | **POST** /v1/api/webdl/asynccreatewebdownload | Async Create Web Download |
| [**ControlWebDownload**](WebDownloadsApi.md#controlwebdownload) | **POST** /v1/api/webdl/controlwebdownload | Control Web Download |
| [**CreateWebDownload**](WebDownloadsApi.md#createwebdownload) | **POST** /v1/api/webdl/createwebdownload | Create Web Download |
| [**EditWebDownloadItem**](WebDownloadsApi.md#editwebdownloaditem) | **PUT** /v1/api/webdl/editwebdownload | Edit Web Download Item |
| [**GetHosterList**](WebDownloadsApi.md#gethosterlist) | **GET** /v1/api/webdl/hosters | Get Hoster List |
| [**GetWebDownloadCachedAvailability**](WebDownloadsApi.md#getwebdownloadcachedavailability) | **GET** /v1/api/webdl/checkcached | Get Web Download Cached Availability |
| [**GetWebDownloadCachedAvailabilityBatch**](WebDownloadsApi.md#getwebdownloadcachedavailabilitybatch) | **POST** /v1/api/webdl/checkcached | Get Web Download Cached Availability Batch |
| [**GetWebDownloadList**](WebDownloadsApi.md#getwebdownloadlist) | **GET** /v1/api/webdl/mylist | Get Web Download List |
| [**RequestWebDownloadLink**](WebDownloadsApi.md#requestwebdownloadlink) | **GET** /v1/api/webdl/requestdl | Request Download Link |
| [**RequestWebDownloadLinksGet**](WebDownloadsApi.md#requestwebdownloadlinksget) | **GET** /v1/api/webdl/requestdl/batch | Request Download Links - GET |
| [**RequestWebDownloadLinksPost**](WebDownloadsApi.md#requestwebdownloadlinkspost) | **POST** /v1/api/webdl/requestdl/batch | Request Download Links - POST |

<a id="asynccreatewebdownload"></a>
# **AsyncCreateWebDownload**
> AsyncCreateWebDownloadResponse AsyncCreateWebDownload (string link, string password = null, string name = null, bool asQueued = null, bool addOnlyIfCached = null)

Async Create Web Download

### Overview  Creates a web download asynchronously under your account. Simply send a link to any file on the internet. Once it has been checked, it will begin downloading assuming your account has available active download slots, and they aren't too large.  The request will return instantly, not returning any data other than a success message. This is the same for failures, as they will return the error in the background as a notification, rather than immediately.  ### Rate Limits  This endpoint is rate limited to **60 requests per hour** per API token.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **link** | **string** | An accessible link to any file on the internet. Cannot be a redirection. |  |
| **password** | **string** | Password to the file, if the files requires it. Optional. | [optional]  |
| **name** | **string** | The name you want the web download to be. Optional. | [optional]  |
| **asQueued** | **bool** | Tells TorBox you want this web download instantly queued. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**AsyncCreateWebDownloadResponse**](AsyncCreateWebDownloadResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

<a id="controlwebdownload"></a>
# **ControlWebDownload**
> ControlWebDownloadResponse ControlWebDownload (ControlWebDownload controlWebDownload)

Control Web Download

### Overview  Controls a web download. By sending the web download's ID and the type of operation you want to perform, it will send that request to the debrid client.  Operations are either:  - **Delete** `deletes the download from the client and your account permanently`   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **controlWebDownload** | [**ControlWebDownload**](ControlWebDownload.md) |  |  |

### Return type

[**ControlWebDownloadResponse**](ControlWebDownloadResponse.md)

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

<a id="createwebdownload"></a>
# **CreateWebDownload**
> CreateWebDownloadResponse CreateWebDownload (string link, string password = null, string name = null, bool asQueued = null, bool addOnlyIfCached = null)

Create Web Download

### Overview  Creates a web download under your account. Simply send a link to any file on the internet. Once it has been checked, it will begin downloading assuming your account has available active download slots, and they aren't too large.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **link** | **string** | An accessible link to any file on the internet. Cannot be a redirection. |  |
| **password** | **string** | Password to the file, if the files requires it. Optional. | [optional]  |
| **name** | **string** | The name you want the torrent to be. Optional. | [optional]  |
| **asQueued** | **bool** | Tells TorBox you want this web download.instantly queued. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**CreateWebDownloadResponse**](CreateWebDownloadResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

<a id="editwebdownloaditem"></a>
# **EditWebDownloadItem**
> EditWebDownloadItemResponse EditWebDownloadItem (EditWebDownload editWebDownload)

Edit Web Download Item

### Overview  Updates a download item based on the item's ID. Sending a PUT request with valid items overwrites the previous items entirely, so use this endpoint with caution. Please make sure to read the restrictions below as they are important.  ### Restrictions  - Does not affect the cached database (or any other user's item).  - Name must pass validation:      - Above 1 character long.      - Below 200 characters long.      - Cannot contain any non-url or non filesystem safe characters. (This is removed automatically).      - Cannot contain any leading or trailing whitespace. You can have spaces in the middle. (This is removed automatically).  - Tags follow the same rules as the name.  - Alternative hashes must be of MD5, SHA1, or SHA256.   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **editWebDownload** | [**EditWebDownload**](EditWebDownload.md) |  |  |

### Return type

[**EditWebDownloadItemResponse**](EditWebDownloadItemResponse.md)

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

<a id="gethosterlist"></a>
# **GetHosterList**
> GetHosterListResponse GetHosterList ()

Get Hoster List

### Overview  A dynamic list of hosters that TorBox is capable of downloading through its paid service.  - **Name** - a clean name for display use, the well known name of the service, should be recognizable to users.  - **Domains** - an array of known domains that the hoster uses. While each may serve a different purpose it is still included.  - **URL** - the main url of the service. This should take you to the home page or a service page of the hoster.  - **Icon** - a square image, usually a favicon or logo, that represents the service, should be recognizable as the hoster's icon.  - **Status** - whether this hoster can be used on TorBox or not at the current time. It is usually a good idea to check this value before submitting a download to TorBox's servers for download.  - **Type** - values are either \"hoster\" or \"stream\". Both do the same thing, but is good to differentiate services used for different things.  - **Note** - a string value (or null) that may give helpful information about the current status or state of a hoster. This can and should be shown to end users.  - **Daily Link Limit** - the number of downloads a user can use per day. As a user submits links, once they hit this number, the API will deny them from adding anymore of this type of link. A zero value means that it is unlimited.  - **Daily Link Used** - the number of downloads a user has already used. Usually zero unless you send authentication to the endpoint. This will return accurate values.  - **Daily Bandwidth Limit** - the value in bytes that a user is allowed to download from this hoster. A zero value means that it is unlimited. It is recommended to use the Daily Link Limit instead.  - **Daily Bandwidth Used** - the value in bytes that a user has already used to download from this hoster. Usually zero unless you send authentication to the endpoint. This will return accurate values.   ### Authorization  Optional authorization. Authorization is not required in this endpoint unless you want to get the user's live data. Requires an API key using the Authorization Bearer Header to get the live and accurate data for **Daily Link Used** and **Daily Bandwidth Used**. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetHosterListResponse**](GetHosterListResponse.md)

### Authorization

No authorization required

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
| **429** | Too Many Requests |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getwebdownloadcachedavailability"></a>
# **GetWebDownloadCachedAvailability**
> GetWebDownloadCachedAvailabilityResponse GetWebDownloadCachedAvailability (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Web Download Cached Availability

### Overview  Takes in a list of comma separated usenet hashes and checks if the web download is cached. This endpoint only gets a max of around 100 at a time, due to http limits in queries. If you want to do more, you can simply do more hash queries. Such as: `?hash=XXXX&hash=XXXX&hash=XXXX`  or `?hash=XXXX,XXXX&hash=XXXX&hash=XXXX,XXXX` and this will work too. Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  To get the hash of a web download you can read [this document](https://support.torbox.app/en/articles/13681109-technical-getting-hashes-for-searches) for all of the strategies.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) | The list of web hashes you want to check. Comma seperated. To find the hash, md5 the link. | [optional]  |
| **format** | **string** | Format you want the data in. Acceptable is either \&quot;object\&quot; or \&quot;list\&quot;. List is the most performant option as it doesn&#39;t require modification of the list. | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** | Allows you to list the files found inside the cached data. | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetWebDownloadCachedAvailabilityResponse**](GetWebDownloadCachedAvailabilityResponse.md)

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

<a id="getwebdownloadcachedavailabilitybatch"></a>
# **GetWebDownloadCachedAvailabilityBatch**
> GetWebDownloadCachedAvailabilityBatchResponse GetWebDownloadCachedAvailabilityBatch (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Web Download Cached Availability Batch

### Overview  Takes in a list of comma separated hashes and checks if the torrent is cached. With the POST endpoint you can submit a nearly unlimited hashes compared to the GET endpoint which is limited by url parameters.  Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **format** | **string** | Format you want the data in. Acceptable is either \&quot;object\&quot; or \&quot;list\&quot;. List is the most performant option as it doesn&#39;t require modification of the list. | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** | Allows you to list the files found inside the cached data. | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetWebDownloadCachedAvailabilityBatchResponse**](GetWebDownloadCachedAvailabilityBatchResponse.md)

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

<a id="getwebdownloadlist"></a>
# **GetWebDownloadList**
> GetWebDownloadListResponse GetWebDownloadList (long id = null, bool bypassCache = null, long offset = null, long limit = null, bool files = null, bool active = null)

Get Web Download List

### Overview  Gets the user's web download list. This gives you the needed information to perform other usenet actions. Unlike Torrents, this information is updated on its own every 5 seconds for live web downloads.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


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

[**GetWebDownloadListResponse**](GetWebDownloadListResponse.md)

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

<a id="requestwebdownloadlink"></a>
# **RequestWebDownloadLink**
> RequestWebDownloadLinkResponse RequestWebDownloadLink (string token, long webId, long fileId = null, bool zipLink = null, string userIp = null, bool redirect = null, bool appendName = null)

Request Download Link

### Overview  Requests the download link from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Permalinks  Instead of generating many CDN urls by requesting this endpoint, you can instead create a permalink such as: `https://api.torbox.app/v1/api/torrents/requestdl?token=APIKEY&torrent_id=NUMBER&file_id=NUMBER&redirect=true` and when a user clicks on it, it will automatically redirect them to the CDN link. This saves requests and doesn't abuse the API. Use this method rather than saving CDN links as they are not permanent. To invalidate these permalinks, simply reset your API token or delete the item from your dashboard.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **webId** | **long** | The web download&#39;s ID that you want to download |  |
| **fileId** | **long** | The files&#39;s ID that you want to download | [optional] [default to 0] |
| **zipLink** | **bool** | If you want a zip link. Required if no file_id. Takes precedence over file_id if both are given. | [optional] [default to false] |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **redirect** | **bool** | If you want to redirect the user to the CDN link. This is useful for creating permalinks so that you can just make this request URL the link. | [optional] [default to false] |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |

### Return type

[**RequestWebDownloadLinkResponse**](RequestWebDownloadLinkResponse.md)

### Authorization

No authorization required

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

<a id="requestwebdownloadlinksget"></a>
# **RequestWebDownloadLinksGet**
> RequestWebDownloadLinksGetResponse RequestWebDownloadLinksGet (string token, long webId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - GET

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **webId** | **long** | The web download&#39;s ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) | The files&#39;s ID that you want to download | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestWebDownloadLinksGetResponse**](RequestWebDownloadLinksGetResponse.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="requestwebdownloadlinkspost"></a>
# **RequestWebDownloadLinksPost**
> RequestWebDownloadLinksPostResponse RequestWebDownloadLinksPost (string token, long webId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - POST

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **webId** | **long** | The web downloads&#39; ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) |  | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestWebDownloadLinksPostResponse**](RequestWebDownloadLinksPostResponse.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


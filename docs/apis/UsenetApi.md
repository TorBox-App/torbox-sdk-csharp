# TorBox.Sdk.Api.UsenetApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AsyncCreateUsenetDownload**](UsenetApi.md#asynccreateusenetdownload) | **POST** /v1/api/usenet/asynccreateusenetdownload | Async Create Usenet Download |
| [**ControlUsenetDownload**](UsenetApi.md#controlusenetdownload) | **POST** /v1/api/usenet/controlusenetdownload | Control Usenet Download |
| [**CreateUsenetDownload**](UsenetApi.md#createusenetdownload) | **POST** /v1/api/usenet/createusenetdownload | Create Usenet Download |
| [**EditUsenetItem**](UsenetApi.md#editusenetitem) | **PUT** /v1/api/usenet/editusenetdownload | Edit Usenet Item |
| [**GetNewsServerAccount**](UsenetApi.md#getnewsserveraccount) | **GET** /v1/api/usenet/provider/account | Get News Server Account |
| [**GetNewsServerConnectionInformation**](UsenetApi.md#getnewsserverconnectioninformation) | **GET** /v1/api/usenet/provider/connection | Get News Server Connection Information |
| [**GetUsenetCachedAvailability**](UsenetApi.md#getusenetcachedavailability) | **GET** /v1/api/usenet/checkcached | Get Usenet Cached Availability |
| [**GetUsenetCachedAvailabilityBatch**](UsenetApi.md#getusenetcachedavailabilitybatch) | **POST** /v1/api/usenet/checkcached | Get Usenet Cached Availability Batch |
| [**GetUsenetList**](UsenetApi.md#getusenetlist) | **GET** /v1/api/usenet/mylist | Get Usenet List |
| [**RequestUsenetDownloadLink**](UsenetApi.md#requestusenetdownloadlink) | **GET** /v1/api/usenet/requestdl | Request Download Link |
| [**RequestUsenetDownloadLinksGet**](UsenetApi.md#requestusenetdownloadlinksget) | **GET** /v1/api/usenet/requestdl/batch | Request Download Links - GET |
| [**RequestUsenetDownloadLinksPost**](UsenetApi.md#requestusenetdownloadlinkspost) | **POST** /v1/api/usenet/requestdl/batch | Request Download Links - POST |
| [**ResetNewsServerAccountPassword**](UsenetApi.md#resetnewsserveraccountpassword) | **POST** /v1/api/usenet/provider/account/resetpw | Reset News Server Account Password |

<a id="asynccreateusenetdownload"></a>
# **AsyncCreateUsenetDownload**
> AsyncCreateUsenetDownloadResponse AsyncCreateUsenetDownload (string link = null, System.IO.Stream file = null, string name = null, string password = null, long postProcessing = null, bool asQueued = null, bool addOnlyIfCached = null)

Async Create Usenet Download

### Overview  Creates a usenet download asynchronously under your account. Simply send **either** a link, or an nzb file. Once they have been checked, they will begin downloading assuming your account has available active download slots, and they aren't too large.  The request will return instantly, not returning any data other than a success message. This is the same for failures, as they will return the error in the background as a notification, rather than immediately.  The post processing options are the same as for the Create Usenet Download endpoint.  ### Rate Limits  This endpoint is rate limited to **60 requests per hour** per API token.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **link** | **string** | An accessible link to an NZB file. Cannot be a redirection. Optional. | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** | An NZB File. Optional. | [optional]  |
| **name** | **string** | The name you want the usenet download to be. Optional. | [optional]  |
| **password** | **string** | The password to send to the Usenet client. This is used for extracting the RAR at the end. Optional. | [optional]  |
| **postProcessing** | **long** | The post processing option to use. Read the overview of the Create Usenet Download endpoint for the options. Default is -1. Optional. | [optional] [default to -1] |
| **asQueued** | **bool** | Tells TorBox you want this usenet download instantly queued. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**AsyncCreateUsenetDownloadResponse**](AsyncCreateUsenetDownloadResponse.md)

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

<a id="controlusenetdownload"></a>
# **ControlUsenetDownload**
> ControlUsenetDownloadResponse ControlUsenetDownload (ControlUsenetDownload controlUsenetDownload)

Control Usenet Download

### Overview  Controls a usenet download. By sending the usenet download's ID and the type of operation you want to perform, it will send that request to the usenet client.  Operations are either:  - **Delete** `deletes the nzb from the client and your account permanently`   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **controlUsenetDownload** | [**ControlUsenetDownload**](ControlUsenetDownload.md) |  |  |

### Return type

[**ControlUsenetDownloadResponse**](ControlUsenetDownloadResponse.md)

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

<a id="createusenetdownload"></a>
# **CreateUsenetDownload**
> CreateUsenetDownloadResponse CreateUsenetDownload (string link = null, System.IO.Stream file = null, string name = null, string password = null, long postProcessing = null, bool asQueued = null, bool addOnlyIfCached = null)

Create Usenet Download

### Overview  Creates a usenet download under your account. Simply send **either** a link, or an nzb file. Once they have been checked, they will begin downloading assuming your account has available active download slots, and they aren't too large.  #### Post Processing Options:  All post processing options that the Usenet client will perform before TorBox's own processing to make the files available. It is recommended you either don't send this parameter, or keep it at `-1` for default, which will give only the wanted files.  - `-1`, Default. This runs repairs, and extractions as well as deletes the source files leaving only the wanted downloaded files.  - `0`, None. No post-processing at all. Just download all the files (including all PAR2). TorBox will still do its normal processing to make the download available, but no repairs, or extraction will take place.  - `1`, Repair. Download files and do a PAR2 verification. If the verification fails, download more PAR2 files and attempt to repair the files.  - `2`, Repair and Unpack. Download all files, do a PAR2 verification and unpack the files. The final folder will also include the RAR and ZIP files.  - `3`, Repair, Unpack and Delete. Download all files, do a PAR2 verification, unpack the files to the final folder and delete the source files.   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **link** | **string** | An accessible link to an NZB file. Cannot be a redirection. Optional. | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** | An NZB File. Optional. | [optional]  |
| **name** | **string** | The name you want the usenet download to be. Optional. | [optional]  |
| **password** | **string** | The password to send to the Usenet client. This is used for extracting the RAR at the end. Optional. | [optional]  |
| **postProcessing** | **long** | The post processing option to use. Read the overview for the options. Default is -1. Optional. | [optional] [default to -1] |
| **asQueued** | **bool** | Tells TorBox you want this usenet download.instantly queued. Optional. | [optional] [default to false] |
| **addOnlyIfCached** | **bool** | Only adds the download if it is cached on TorBox. If not cached, it won&#39;t be added. | [optional] [default to false] |

### Return type

[**CreateUsenetDownloadResponse**](CreateUsenetDownloadResponse.md)

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

<a id="editusenetitem"></a>
# **EditUsenetItem**
> EditUsenetItemResponse EditUsenetItem (EditUsenetDownload editUsenetDownload)

Edit Usenet Item

### Overview  Updates a download item based on the item's ID. Sending a PUT request with valid items overwrites the previous items entirely, so use this endpoint with caution. Please make sure to read the restrictions below as they are important.  ### Restrictions  - Does not affect the cached database (or any other user's item).  - Name must pass validation:      - Above 1 character long.      - Below 200 characters long.      - Cannot contain any non-url or non filesystem safe characters. (This is removed automatically).      - Cannot contain any leading or trailing whitespace. You can have spaces in the middle. (This is removed automatically).  - Tags follow the same rules as the name.  - Alternative hashes must be of MD5, SHA1, or SHA256.   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **editUsenetDownload** | [**EditUsenetDownload**](EditUsenetDownload.md) |  |  |

### Return type

[**EditUsenetItemResponse**](EditUsenetItemResponse.md)

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

<a id="getnewsserveraccount"></a>
# **GetNewsServerAccount**
> GetNewsServerAccountResponse GetNewsServerAccount ()

Get News Server Account

### Overview  Gets the user's TorBox News Server Account with authentication details. Does not show password if not creating the account. Account creation happens on the first request. If you need to get the password, or reset the password, use the `/usenet/provider/account/resetpw` `POST` endpoint.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetNewsServerAccountResponse**](GetNewsServerAccountResponse.md)

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getnewsserverconnectioninformation"></a>
# **GetNewsServerConnectionInformation**
> GetNewsServerConnectionInformationResponse GetNewsServerConnectionInformation ()

Get News Server Connection Information

### Overview  Gets the TorBox News Server Connection information. This is a static path, and is not dynamic.  ### Authorization  No authentication required. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetNewsServerConnectionInformationResponse**](GetNewsServerConnectionInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getusenetcachedavailability"></a>
# **GetUsenetCachedAvailability**
> GetUsenetCachedAvailabilityResponse GetUsenetCachedAvailability (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Usenet Cached Availability

### Overview  Takes in a list of comma separated usenet hashes and checks if the usenet download is cached. This endpoint only gets a max of around 100 at a time, due to http limits in queries. If you want to do more, you can simply do more hash queries. Such as: `?hash=XXXX&hash=XXXX&hash=XXXX`  or `?hash=XXXX,XXXX&hash=XXXX&hash=XXXX,XXXX` and this will work too. Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  To get the hash of a usenet download, you can read [this document](https://support.torbox.app/en/articles/13681109-technical-getting-hashes-for-searches) for all of the strategies.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) | The list of usenet hashes you want to check. Comma seperated. To find the hash, md5 the link of the usenet link or file. | [optional]  |
| **format** | **string** | Format you want the data in. Acceptable is either \&quot;object\&quot; or \&quot;list\&quot;. List is the most performant option as it doesn&#39;t require modification of the list. | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** | Allows you to list the files found inside the cached data. Optional. | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetUsenetCachedAvailabilityResponse**](GetUsenetCachedAvailabilityResponse.md)

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

<a id="getusenetcachedavailabilitybatch"></a>
# **GetUsenetCachedAvailabilityBatch**
> GetUsenetCachedAvailabilityBatchResponse GetUsenetCachedAvailabilityBatch (List<string> hash = null, string format = null, bool listFiles = null, CheckCached checkCached = null)

Get Usenet Cached Availability Batch

### Overview  Takes in a list of comma separated hashes and checks if the torrent is cached. With the POST endpoint you can submit a nearly unlimited hashes compared to the GET endpoint which is limited by url parameters.  Performance is very fast. Less than 1 second per 100. Time is approximately O(log n) time for those interested in taking it to its max. That is without caching as well. This endpoint stores a cache for an hour.  You may also pass a `format` parameter with the format you want the data in. Options are either `object` or `list`. You can view examples of both below.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **hash** | [**List&lt;string&gt;**](string.md) |  | [optional]  |
| **format** | **string** |  | [optional] [default to &quot;object&quot;] |
| **listFiles** | **bool** |  | [optional] [default to false] |
| **checkCached** | [**CheckCached**](CheckCached.md) |  | [optional]  |

### Return type

[**GetUsenetCachedAvailabilityBatchResponse**](GetUsenetCachedAvailabilityBatchResponse.md)

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

<a id="getusenetlist"></a>
# **GetUsenetList**
> GetUsenetListResponse GetUsenetList (long id = null, bool bypassCache = null, long offset = null, long limit = null, bool files = null, bool active = null)

Get Usenet List

### Overview  Gets the user's usenet download list. This gives you the needed information to perform other usenet actions. Unlike Torrents, this information is updated on its own every 5 seconds for live usenet downloads.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Determines the usenet download requested, will return an object rather than list. Optional. | [optional]  |
| **bypassCache** | **bool** | Allows you to bypass the cached data, and always get fresh information. Useful if constantly querying for fresh download stats. Otherwise, we request that you save our database a few calls. | [optional] [default to false] |
| **offset** | **long** | Determines the offset of items to get from the database. Default is 0. Optional. | [optional] [default to 0] |
| **limit** | **long** | Determines the number of items to recieve per request. Default is 1000. Optional. | [optional] [default to 1000] |
| **files** | **bool** | Exclude files from response. Optional | [optional] [default to true] |
| **active** | **bool** | Shows only active downloads. Optional | [optional]  |

### Return type

[**GetUsenetListResponse**](GetUsenetListResponse.md)

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

<a id="requestusenetdownloadlink"></a>
# **RequestUsenetDownloadLink**
> RequestUsenetDownloadLinkResponse RequestUsenetDownloadLink (string token, long usenetId, long fileId = null, bool zipLink = null, string userIp = null, bool redirect = null, bool appendName = null)

Request Download Link

### Overview  Requests the download link from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Permalinks  Instead of generating many CDN urls by requesting this endpoint, you can instead create a permalink such as: `https://api.torbox.app/v1/api/torrents/requestdl?token=APIKEY&torrent_id=NUMBER&file_id=NUMBER&redirect=true` and when a user clicks on it, it will automatically redirect them to the CDN link. This saves requests and doesn't abuse the API. Use this method rather than saving CDN links as they are not permanent. To invalidate these permalinks, simply reset your API token or delete the item from your dashboard.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **usenetId** | **long** | The usenet download&#39;s ID that you want to download |  |
| **fileId** | **long** | The files&#39;s ID that you want to download. Optional if using \&quot;zip_link\&quot;. | [optional] [default to 0] |
| **zipLink** | **bool** | If you want a zip link. Required if no file_id. Takes precedence over file_id if both are given. | [optional] [default to false] |
| **userIp** | **string** | The user&#39;s IPv4 to determine the closest CDN. Optional. | [optional]  |
| **redirect** | **bool** | If you want to redirect the user to the CDN link. This is useful for creating permalinks so that you can just make this request URL the link. | [optional] [default to false] |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |

### Return type

[**RequestUsenetDownloadLinkResponse**](RequestUsenetDownloadLinkResponse.md)

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

<a id="requestusenetdownloadlinksget"></a>
# **RequestUsenetDownloadLinksGet**
> RequestUsenetDownloadLinksGetResponse RequestUsenetDownloadLinksGet (string token, long usenetId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - GET

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **usenetId** | **long** | The usenet download&#39;s ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) | The files&#39;s ID that you want to download | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestUsenetDownloadLinksGetResponse**](RequestUsenetDownloadLinksGetResponse.md)

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

<a id="requestusenetdownloadlinkspost"></a>
# **RequestUsenetDownloadLinksPost**
> RequestUsenetDownloadLinksPostResponse RequestUsenetDownloadLinksPost (string token, long usenetId, List<long> fileIds = null, string userIp = null, bool appendName = null, RequestDownloadBatch requestDownloadBatch = null)

Request Download Links - POST

### Overview  Requests multiple download links from the server. Because downloads are metered, TorBox cannot afford to allow free access to the links directly. This endpoint opens the link for 3 hours for downloads. Once a download is started, the user has nearly unlilimited time to download the file. The 1 hour time limit is simply for starting downloads. This prevents long term link sharing.  ### Authorization  Requires an API key as a parameter for the `token` parameter. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | Your API Key |  |
| **usenetId** | **long** | The usenet downloads&#39; ID that you want to download |  |
| **fileIds** | [**List&lt;long&gt;**](long.md) |  | [optional]  |
| **userIp** | **string** | The user&#39;s IP to determine the closest CDN. Optional. | [optional]  |
| **appendName** | **bool** | If you want to add the \&quot;filename\&quot; parameter to the returned CDN link. Optional. Default false. | [optional] [default to false] |
| **requestDownloadBatch** | [**RequestDownloadBatch**](RequestDownloadBatch.md) |  | [optional]  |

### Return type

[**RequestUsenetDownloadLinksPostResponse**](RequestUsenetDownloadLinksPostResponse.md)

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

<a id="resetnewsserveraccountpassword"></a>
# **ResetNewsServerAccountPassword**
> ResetNewsServerAccountPasswordResponse ResetNewsServerAccountPassword ()

Reset News Server Account Password

### Overview  Resets the user's TorBox News Server account password. This password is automatically generated, and is not saved, it is only shown once.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ResetNewsServerAccountPasswordResponse**](ResetNewsServerAccountPasswordResponse.md)

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


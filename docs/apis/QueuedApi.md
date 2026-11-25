# TorBox.Sdk.Api.QueuedApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ControlQueuedDownloads**](QueuedApi.md#controlqueueddownloads) | **POST** /v1/api/queued/controlqueued | Control Queued Downloads |
| [**GetQueuedDownloads**](QueuedApi.md#getqueueddownloads) | **GET** /v1/api/queued/getqueued | Get Queued Downloads |

<a id="controlqueueddownloads"></a>
# **ControlQueuedDownloads**
> ControlQueuedDownloadsResponse ControlQueuedDownloads (ControlQueuedDownload controlQueuedDownload)

Control Queued Downloads

### Overview  Controls a queued torrent. By sending the queued torrent's ID and the type of operation you want to perform, it will perform that action on the queued torrent.  Operations are either:  - **Delete** `deletes the queued download from your account`  - **Start** `starts a queued download, cannot be used with the \"all\" parameter`   ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **controlQueuedDownload** | [**ControlQueuedDownload**](ControlQueuedDownload.md) |  |  |

### Return type

[**ControlQueuedDownloadsResponse**](ControlQueuedDownloadsResponse.md)

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

<a id="getqueueddownloads"></a>
# **GetQueuedDownloads**
> GetQueuedDownloadsResponse GetQueuedDownloads (long id = null, string type = null, bool bypassCache = null, long offset = null, long limit = null)

Get Queued Downloads

### Overview  Retrieves all of a user's queued downloads by type. If you want to get all 3 types, \"torrent\", \"usenet\" and \"webdl\" then you will need to run this request 3 times, each with the different type.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Determines the queued download requested, will return an object rather than list. Optional. | [optional]  |
| **type** | **string** | The type of the queued download you want to retrieve. Can be \&quot;torrent\&quot;, \&quot;usenet\&quot; or \&quot;webdl\&quot;. Optional. Default is \&quot;torrent\&quot;. | [optional] [default to &quot;torrent&quot;] |
| **bypassCache** | **bool** | Allows you to bypass the cached data, and always get fresh information. Useful if constantly querying for fresh download stats. Otherwise, we request that you save our database a few calls. | [optional] [default to false] |
| **offset** | **long** | Determines the offset of items to get from the database. Default is 0. Optional. | [optional] [default to 0] |
| **limit** | **long** | Determines the number of items to recieve per request. Default is 1000. Optional. | [optional] [default to 1000] |

### Return type

[**GetQueuedDownloadsResponse**](GetQueuedDownloadsResponse.md)

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


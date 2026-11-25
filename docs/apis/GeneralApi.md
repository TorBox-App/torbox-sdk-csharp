# TorBox.Sdk.Api.GeneralApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Get30DayStats**](GeneralApi.md#get30daystats) | **GET** /v1/api/stats/30days | Get 30 Day Stats |
| [**GetChangelogsJson**](GeneralApi.md#getchangelogsjson) | **GET** /v1/api/changelogs/json | Get Changelogs JSON |
| [**GetChangelogsRssFeed**](GeneralApi.md#getchangelogsrssfeed) | **GET** /v1/api/changelogs/rss | Get Changelogs RSS Feed |
| [**GetSpeedtestFiles**](GeneralApi.md#getspeedtestfiles) | **GET** /v1/api/speedtest | Get Speedtest Files |
| [**GetStats**](GeneralApi.md#getstats) | **GET** /v1/api/stats | Get Stats |
| [**GetUpStatus**](GeneralApi.md#getupstatus) | **GET** / | Get Up Status |

<a id="get30daystats"></a>
# **Get30DayStats**
> Get30DayStatsResponse Get30DayStats ()

Get 30 Day Stats

### Overview  Gets the general stats of the TorBox service for the last 30 days, one entry per day. Each entry is a snapshot of the totals at that time.  ### Authorization  None needed. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**Get30DayStatsResponse**](Get30DayStatsResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchangelogsjson"></a>
# **GetChangelogsJson**
> GetChangelogsJsonResponse GetChangelogsJson (long offset = null, long limit = null)

Get Changelogs JSON

### Overview  Gets most recent changelogs from [https://feedback.torbox.app/changelog](https://feedback.torbox.app/changelog). This is useful for developers who want to integrate the changelog into their apps for their users to see. Includes content in HTML for developers to easily render the text in a fancy yet simple way.  ### Authorization  None needed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **long** |  | [optional] [default to 0] |
| **limit** | **long** |  | [optional] [default to 10] |

### Return type

[**GetChangelogsJsonResponse**](GetChangelogsJsonResponse.md)

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
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchangelogsrssfeed"></a>
# **GetChangelogsRssFeed**
> string GetChangelogsRssFeed (long offset = null, long limit = null)

Get Changelogs RSS Feed

### Overview  Gets most recent 100 changelogs from [https://feedback.torbox.app/changelog](https://feedback.torbox.app/changelog). This is useful for people who want updates on the TorBox changelog. Includes all the necessary items to make this compatible with RSS feed viewers for notifications, and proper HTML viewing.  ### Authorization  None needed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **offset** | **long** |  | [optional] [default to 0] |
| **limit** | **long** |  | [optional] [default to 10] |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspeedtestfiles"></a>
# **GetSpeedtestFiles**
> GetSpeedtestFilesResponse GetSpeedtestFiles (string userIp = null, string region = null, string testLength = null)

Get Speedtest Files

### Overview  Gets CDN speedtest files. This can be used for speedtesting TorBox for users or other usages, such as checking download speeds for verification. Provides all necessary data such as region, server name, and even coordinates. Uses the requesting IP to determine if the server is the closest to the user.  You also have the ability to choose between long tests or short tests via the \"test_length\" parameter. You may also force the region selection by passing the \"region\" as a specific region.  ### Authorization  None needed. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIp** | **string** | Pass a user&#39;s IP to get the closest server to them, otherwise will use the calling IP for location. | [optional]  |
| **region** | **string** | Determines what cdns are returned. May be any region that TorBox is located in. To get this value, send a request without this value to determine all of the available regions that are available. | [optional] [default to &quot;all&quot;] |
| **testLength** | **string** | Determines the size of the file used for the speedtest. May be \&quot;long\&quot; or \&quot;short\&quot;. Optional. | [optional] [default to &quot;short&quot;] |

### Return type

[**GetSpeedtestFilesResponse**](GetSpeedtestFilesResponse.md)

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
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstats"></a>
# **GetStats**
> GetStatsResponse GetStats ()

Get Stats

### Overview  Simply gets general stats about the TorBox service.  ### Authorization  None needed. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetStatsResponse**](GetStatsResponse.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getupstatus"></a>
# **GetUpStatus**
> GetUpStatusResponse GetUpStatus ()

Get Up Status

### Overview  Simply gets if the TorBox API is available for use or not. Also might include information about downtimes.  ### Authorization  None needed. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetUpStatusResponse**](GetUpStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **404** | Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **502** | Bad Gateway |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


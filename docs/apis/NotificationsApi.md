# TorBox.Sdk.Api.NotificationsApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ClearAllNotifications**](NotificationsApi.md#clearallnotifications) | **POST** /v1/api/notifications/clear | Clear All Notifications |
| [**ClearSingleNotification**](NotificationsApi.md#clearsinglenotification) | **POST** /v1/api/notifications/clear/{id} | Clear Single Notification |
| [**GetNotificationFeed**](NotificationsApi.md#getnotificationfeed) | **GET** /v1/api/notifications/mynotifications | Get Notification Feed |
| [**GetRssNotificationFeed**](NotificationsApi.md#getrssnotificationfeed) | **GET** /v1/api/notifications/rss | Get RSS Notification Feed |
| [**SendTestNotification**](NotificationsApi.md#sendtestnotification) | **POST** /v1/api/notifications/test | Send Test Notification |

<a id="clearallnotifications"></a>
# **ClearAllNotifications**
> ClearAllNotificationsResponse ClearAllNotifications ()

Clear All Notifications

### Overview  Marks all of your notifications as read and deletes them permanently.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ClearAllNotificationsResponse**](ClearAllNotificationsResponse.md)

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

<a id="clearsinglenotification"></a>
# **ClearSingleNotification**
> ClearSingleNotificationResponse ClearSingleNotification (string id)

Clear Single Notification

### Overview  Marks a single notification as read and permanently deletes it from your notifications. Requires a `notification_id` which can be found by getting your notification feed.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ClearSingleNotificationResponse**](ClearSingleNotificationResponse.md)

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

<a id="getnotificationfeed"></a>
# **GetNotificationFeed**
> GetNotificationFeedResponse GetNotificationFeed (bool bypassCache = null)

Get Notification Feed

### Overview  Gets your notifications in a JSON object that is easily parsable compared to the RSS Feed. Gives all the same data as the RSS Feed.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bypassCache** | **bool** |  | [optional] [default to false] |

### Return type

[**GetNotificationFeedResponse**](GetNotificationFeedResponse.md)

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

<a id="getrssnotificationfeed"></a>
# **GetRssNotificationFeed**
> string GetRssNotificationFeed (string token)

Get RSS Notification Feed

### Overview  Gets your notifications in an RSS Feed which allows you to use them with RSS Feed readers or notification services that can take RSS Feeds and listen to updates. As soon as a notification goes to your account, it will be added to your feed.  ### Authorization  Requires an API key using as a query parameter using the `token` key. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | The user&#39;s API key. |  |

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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="sendtestnotification"></a>
# **SendTestNotification**
> SendTestNotificationResponse SendTestNotification ()

Send Test Notification

### Overview  Sends a test notification to all enabled notification types. This can be useful for validating setups. No need for any body in this request.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**SendTestNotificationResponse**](SendTestNotificationResponse.md)

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


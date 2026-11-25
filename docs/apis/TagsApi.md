# TorBox.Sdk.Api.TagsApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ControlTag**](TagsApi.md#controltag) | **POST** /v1/api/tags/controltag | Control Tag |
| [**EditTag**](TagsApi.md#edittag) | **PUT** /v1/api/tags/edittag | Edit Tag |
| [**GetTags**](TagsApi.md#gettags) | **GET** /v1/api/tags/mytags | Get User Tags |

<a id="controltag"></a>
# **ControlTag**
> ControlTagResponse ControlTag (ControlTag controlTag)

Control Tag

### Overview  Controls a tag. Currently, the only operation is \"delete\", which deletes the tag and removes it from every download using it; the downloads stay in your account and are otherwise unmodified. The ID is the tag's ID from `/mytags` endpoint.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **controlTag** | [**ControlTag**](ControlTag.md) |  |  |

### Return type

[**ControlTagResponse**](ControlTagResponse.md)

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

<a id="edittag"></a>
# **EditTag**
> EditTagResponse EditTag (EditTag editTag)

Edit Tag

### Overview  Renames a tag. This new name is case sensitive. The ID is the tag's ID from the `/mytags`. Fails with `DUPLICATE_ITEM` when another of the user's tags already has the same name, in any casing.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **editTag** | [**EditTag**](EditTag.md) |  |  |

### Return type

[**EditTagResponse**](EditTagResponse.md)

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

<a id="gettags"></a>
# **GetTags**
> GetTagsResponse GetTags ()

Get User Tags

### Overview  Gets the tags attached to a user account, with the downloads using each tag, their count and total size.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetTagsResponse**](GetTagsResponse.md)

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


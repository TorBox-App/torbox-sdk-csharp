# TorBox.Sdk.Api.AssistantApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatWithAssistant**](AssistantApi.md#chatwithassistant) | **POST** /v1/api/assistant/chat | Chat With Assistant |
| [**DeleteAssistantConversation**](AssistantApi.md#deleteassistantconversation) | **DELETE** /v1/api/assistant/conversations/{session_id} | Delete Assistant Conversation |
| [**DeleteAssistantConversations**](AssistantApi.md#deleteassistantconversations) | **DELETE** /v1/api/assistant/conversations | Delete All Assistant Conversations |
| [**GetAssistantUsage**](AssistantApi.md#getassistantusage) | **GET** /v1/api/assistant/usage | Get Assistant Usage |
| [**ListAssistantConversations**](AssistantApi.md#listassistantconversations) | **GET** /v1/api/assistant/conversations | Get Assistant Conversations |
| [**ReadAssistantConversation**](AssistantApi.md#readassistantconversation) | **GET** /v1/api/assistant/conversations/{session_id} | Get Assistant Conversation |

<a id="chatwithassistant"></a>
# **ChatWithAssistant**
> string ChatWithAssistant (ChatRequest chatRequest)

Chat With Assistant

### Overview  Send a message to the AI Assistant. Optionally include a `session_id` to resume a previous conversation. If no `session_id` is given, the AI will have no previous context and will create a new conversation.  Also included is a way to upload `files` in base64 allowing you to attach a file that the AI Assistant can use.  We also allow you to send `blocks` which is a list of strings that state what additional features your chat interface includes. If no `blocks` are sent, responses are sent in plain text and markdown (for things like tables or bolding text).  The answer is streamed as plain text while it is written. Send the header `Accept: text/event-stream` to get it as server-sent events instead: `tool` with the `name` of each tool the assistant uses, `text` with each piece of the answer, `support` with the `id` of the support conversation when the chat is handed to the support team, `usage` with the share of the day's allowance that is `used` and when it `resets_at`, `error` with the error if the answer fails, and `done` at the end.  ``` event: tool data: {\"name\": \"get_torrent_list\"}  event: text data: {\"text\": \"You have 2 torrents, \"}  event: text data: {\"text\": \"and both have finished downloading.\"}  event: usage data: {\"used\": 0.0123, \"resets_at\": \"2026-01-01T00:00:00Z\"}  event: done data: {} ```  The `X-Session-ID` response header holds the `session_id` to send with the next message.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatRequest** | [**ChatRequest**](ChatRequest.md) |  |  |

### Return type

**string**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json


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

<a id="deleteassistantconversation"></a>
# **DeleteAssistantConversation**
> DeleteAssistantConversationResponse DeleteAssistantConversation (string sessionId)

Delete Assistant Conversation

### Overview  Deletes a specific conversation with the AI assistant. Usage persists from the conversation.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string** | The session you want to retrieve. |  |

### Return type

[**DeleteAssistantConversationResponse**](DeleteAssistantConversationResponse.md)

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

<a id="deleteassistantconversations"></a>
# **DeleteAssistantConversations**
> DeleteAssistantConversationsResponse DeleteAssistantConversations ()

Delete All Assistant Conversations

### Overview  Deletes all conversations for a user's account. Usage persists from the conversations.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**DeleteAssistantConversationsResponse**](DeleteAssistantConversationsResponse.md)

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

<a id="getassistantusage"></a>
# **GetAssistantUsage**
> GetAssistantUsageResponse GetAssistantUsage ()

Get Assistant Usage

### Overview  Gets the current user's AI assistant usage. Users are limited to a certain number of tokens daily, and this endpoint tells you exactly how much is left as a percentage. This makes it easy for developers so they don't have to spend time counting tokens, which is usually inaccurate.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetAssistantUsageResponse**](GetAssistantUsageResponse.md)

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

<a id="listassistantconversations"></a>
# **ListAssistantConversations**
> ListAssistantConversationsResponse ListAssistantConversations ()

Get Assistant Conversations

### Overview  Gets the user's open conversations. Conversations are sorted newest first. Each conversation is kept for 30 days after its last message.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListAssistantConversationsResponse**](ListAssistantConversationsResponse.md)

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

<a id="readassistantconversation"></a>
# **ReadAssistantConversation**
> ReadAssistantConversationResponse ReadAssistantConversation (string sessionId, long since = null)

Get Assistant Conversation

### Overview  Get a specific user conversation with the AI assistant.  You can pass the `since` parameter with a Unix timestamp, and will show any revisions since that time, this way, you don't waste bandwidth retrieving and updating the entire conversation. If no update has been made since, the data return will be null.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sessionId** | **string** | The session you want to retrieve. |  |
| **since** | **long** | Unix timestamp of the conversation you want to get since this time. | [optional]  |

### Return type

[**ReadAssistantConversationResponse**](ReadAssistantConversationResponse.md)

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


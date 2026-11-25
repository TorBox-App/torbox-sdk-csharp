# TorBox.Sdk.Api.UserApi

All URIs are relative to *https://api.torbox.app*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddReferralToAccount**](UserApi.md#addreferraltoaccount) | **POST** /v1/api/user/addreferral | Add Referral To Account |
| [**DeleteAccount**](UserApi.md#deleteaccount) | **DELETE** /v1/api/user/deleteme | Delete Account |
| [**EditUserSettings**](UserApi.md#editusersettings) | **PUT** /v1/api/user/settings/editsettings | Edit User Settings |
| [**GetConfirmationCode**](UserApi.md#getconfirmationcode) | **GET** /v1/api/user/getconfirmation | Get Confirmation Code |
| [**GetReferralData**](UserApi.md#getreferraldata) | **GET** /v1/api/user/referraldata | Get Referral Data |
| [**GetSubscriptions**](UserApi.md#getsubscriptions) | **GET** /v1/api/user/subscriptions | Get Subscriptions |
| [**GetTokenFromDeviceCodeProcess**](UserApi.md#gettokenfromdevicecodeprocess) | **POST** /v1/api/user/auth/device/token | Get Token From Device Code Process |
| [**GetTransactionPdf**](UserApi.md#gettransactionpdf) | **GET** /v1/api/user/transaction/pdf | Get Transaction PDF |
| [**GetTransactions**](UserApi.md#gettransactions) | **GET** /v1/api/user/transactions | Get Transactions |
| [**GetUserData**](UserApi.md#getuserdata) | **GET** /v1/api/user/me | Get User Data |
| [**GetUserStats**](UserApi.md#getuserstats) | **GET** /v1/api/user/stats | Get User Stats |
| [**RefreshApiToken**](UserApi.md#refreshapitoken) | **POST** /v1/api/user/refreshtoken | Refresh API Token |
| [**StartDeviceCodeAuthorizationProcess**](UserApi.md#startdevicecodeauthorizationprocess) | **GET** /v1/api/user/auth/device/start | Start Device Code Authorization Process |

<a id="addreferraltoaccount"></a>
# **AddReferralToAccount**
> AddReferralToAccountResponse AddReferralToAccount (string referral)

Add Referral To Account

### Overview  Automatically adds a referral code to the user's account. This can be used for developers to automatically add their referral to user's accounts who use their service.  This will not override any referral a user already has. If they already have one, then it cannot be changed using this endpoint. It can only be done by the user on the [website](https://torbox.app/subscription).  ### Authorization  Requires an API key using the Authorization Bearer Header. Use the user's API key, not your own. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **referral** | **string** | A referral code. Must be UUID. |  |

### Return type

[**AddReferralToAccountResponse**](AddReferralToAccountResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="deleteaccount"></a>
# **DeleteAccount**
> DeleteAccountResponse DeleteAccount (DeleteAccountSchema deleteAccountSchema)

Delete Account

### Overview  Permanently deletes the user's TorBox account. This cannot be undone.  Because of how dangerous this action is, it needs two things on top of the API key: the user's session token from the website, and a confirmation code, which is sent to the user's email by the Get Confirmation Code endpoint.  ### Authorization  Requires an API key using the Authorization Bearer Header, as well as the session token and the confirmation code in the body. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteAccountSchema** | [**DeleteAccountSchema**](DeleteAccountSchema.md) |  |  |

### Return type

[**DeleteAccountResponse**](DeleteAccountResponse.md)

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
| **410** | Gone |  -  |
| **422** | Validation Error |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="editusersettings"></a>
# **EditUserSettings**
> EditUserSettingsResponse EditUserSettings (BaseSettingsModel baseSettingsModel)

Edit User Settings

### Overview  Edits a user's TorBox settings. These values take effect immediately. Please view the body to read about allowed options and parameters.  To get the user settings, simply use the \"[Get User Data](https://api.torbox.app/docs#/User/get_user_data)\" endpoint, while sending the \"?settings=true\" parameter  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseSettingsModel** | [**BaseSettingsModel**](BaseSettingsModel.md) |  |  |

### Return type

[**EditUserSettingsResponse**](EditUserSettingsResponse.md)

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

<a id="getconfirmationcode"></a>
# **GetConfirmationCode**
> GetConfirmationCodeResponse GetConfirmationCode ()

Get Confirmation Code

### Overview  Requests a 6 digit code to be sent to the user's email for verification. Used to verify a user actually wants to perform a potentially dangerous action.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetConfirmationCodeResponse**](GetConfirmationCodeResponse.md)

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

<a id="getreferraldata"></a>
# **GetReferralData**
> GetReferralDataResponse GetReferralData ()

Get Referral Data

### Overview  Use this endpoint to get the user's referral data. This includes information such as how many referrals they have made, and their referral code.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetReferralDataResponse**](GetReferralDataResponse.md)

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

<a id="getsubscriptions"></a>
# **GetSubscriptions**
> GetSubscriptionsResponse GetSubscriptions ()

Get Subscriptions

### Overview  Gets a users subscriptions. This includes active and inactive subscriptions for all payment processors.  It should be noted that \"plan_code\" is not normalized to the standard plan codes such as 1, 2, or 3. These \"plan_code\"s are payment processor specific and used internally. If you want to display these subscriptions, use the \"plan_name\".  For displaying information to users, use the \"status\", \"gateway\", and \"plan_name\". No other information is relevant to the user, and the rest is used for TorBox internally.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetSubscriptionsResponse**](GetSubscriptionsResponse.md)

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

<a id="gettokenfromdevicecodeprocess"></a>
# **GetTokenFromDeviceCodeProcess**
> GetTokenFromDeviceCodeProcessResponse GetTokenFromDeviceCodeProcess (DeviceTokenSchema deviceTokenSchema)

Get Token From Device Code Process

### Overview  Gets the user's API token from the device code authorization process. This endpoint is expected to be polled in interval until it returns success, or until the expiry has passed. All data you need for this request is in the [original request](https://api.torbox.app/docs#/User/start_device_code_authorization_process), which includes the interval to be polled by, the expiry time to stop at, and `device_code` to be sent to the API to get the correct data.  ### Authorization  None required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deviceTokenSchema** | [**DeviceTokenSchema**](DeviceTokenSchema.md) |  |  |

### Return type

[**GetTokenFromDeviceCodeProcessResponse**](GetTokenFromDeviceCodeProcessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

<a id="gettransactionpdf"></a>
# **GetTransactionPdf**
> string GetTransactionPdf (string transactionId)

Get Transaction PDF

### Overview  Generates a PDF of the transaction information. Requires the transaction ID from the \"Get Transactions\" request.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | The transaction ID that you want to generate the PDF for. |  |

### Return type

**string**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf, application/json


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

<a id="gettransactions"></a>
# **GetTransactions**
> GetTransactionsResponse GetTransactions ()

Get Transactions

### Overview  Use this endpoint to get the user's list of transactions. This data isn't exactly relevant to a third party developer, unless you want to build full parity with TorBox's dashboard, or simply want to show this information.  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetTransactionsResponse**](GetTransactionsResponse.md)

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

<a id="getuserdata"></a>
# **GetUserData**
> GetUserDataResponse GetUserData (bool settings = null, bool downloadStats = null, bool referral = null)

Get User Data

### Overview  Gets a users account data and information.  ### Plans  `0` is Free plan  `1` is Essential plan (_$3 plan_)  `2` is Pro plan (_$10 plan_)  `3` is Standard plan (_$5 plan_)  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settings** | **bool** | Allows you to retrieve user settings. | [optional] [default to false] |
| **downloadStats** | **bool** |  | [optional] [default to false] |
| **referral** | **bool** |  | [optional] [default to false] |

### Return type

[**GetUserDataResponse**](GetUserDataResponse.md)

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

<a id="getuserstats"></a>
# **GetUserStats**
> GetUserStatsResponse GetUserStats (bool general = null, bool bandwidth = null, string bandwidthGrouping = null)

Get User Stats

### Overview  Gets a users stats. This data is currently split into two sections, \"general\" and \"bandwidth\". General shows general data, such as \"Total Data Downloaded\", \"Total Data Egress\", \"Overall Ratio\", and \"Total Downloaded\". Bandwidth shows the amount of bandwidth a user has downloaded within the past 30 days. We don't store this data for longer than 30 days, and it can be made more or less granular. Makes cool graphs!  ### Authorization  Requires an API key using the Authorization Bearer Header. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **general** | **bool** | Retrieve general stats. | [optional] [default to true] |
| **bandwidth** | **bool** | Retrieve bandwidth stats. | [optional] [default to false] |
| **bandwidthGrouping** | **string** | If the \&quot;bandwidth\&quot; query parameter is sent, this value is used. Allowed is \&quot;hour\&quot;, \&quot;day\&quot;, \&quot;week\&quot;, and \&quot;month\&quot;, this narrates how bandwidth is grouped. More granular shows more information. | [optional] [default to &quot;day&quot;] |

### Return type

[**GetUserStatsResponse**](GetUserStatsResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="refreshapitoken"></a>
# **RefreshApiToken**
> RefreshApiTokenResponse RefreshApiToken (RefreshTokenSchema refreshTokenSchema)

Refresh API Token

### Overview  If you want a new API token, or your old one has been compromised, you may request a new one. If you happen to forget the token, go the [TorBox settings page ](https://torbox.app/settings) and copy the current one. If this still doesn't work, you may contact us at our support email for a new one.  ### Authorization  Requires an API key using the Authorization Bearer Header as well as passing the `session_token` from the website to be passed in the body. You can find the `session_token` in the localStorage of your browser on any TorBox.app page under the key `torbox_session_token`. This is a temporary token that only lasts for 1 hour, which is why it is used here to verify the identity of a user as well as their API token. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **refreshTokenSchema** | [**RefreshTokenSchema**](RefreshTokenSchema.md) |  |  |

### Return type

[**RefreshApiTokenResponse**](RefreshApiTokenResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
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

<a id="startdevicecodeauthorizationprocess"></a>
# **StartDeviceCodeAuthorizationProcess**
> StartDeviceCodeAuthorizationProcessResponse StartDeviceCodeAuthorizationProcess (string app = null)

Start Device Code Authorization Process

### Overview  Starts the device code authorization process. Returns all the necessary information to complete the rest of the flow. This includes the following:  - `device_code` - The code your app will use for consecutive requests for getting the user token.  - `code` - This is the 6 digit code that you show to the user to be entered at the following verification_url.  - `verification_url` - This url which you will show as a QR code.  - `friendly_verification_url` - The friendly short url which you can show as plain text to user if they cannot use the QR code method.   You may also submit the `app` parameter to this request to show your app name on the `verification_url` page. This concretes user trust in authorizing your application to use their TorBox account. This is not required, but is a good idea. Default is \"Third Party App\". This name is also only allowed to be alpha-numeric characters (_A-Z,0-9_). Anything else will be filtered our when being shown to the user. The `friendly_verification_url` will always show \"Third Party App\" to keep the URL short.  The device_code is only valid for 10 minutes. Make sure the user is aware of this time limit so they submit and login before this time limit is over.  ### Authorization  None required. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **app** | **string** | The app name that the user will see when verifying the code. This should be the name of your app. | [optional] [default to &quot;Third Party App&quot;] |

### Return type

[**StartDeviceCodeAuthorizationProcessResponse**](StartDeviceCodeAuthorizationProcessResponse.md)

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


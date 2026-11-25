# TorBox.Sdk.Model.ApiError
The envelope every error is answered with. `error` is the stable code to branch on, `detail` the message for people.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | False when the request failed. A list with nothing to return answers &#x60;ITEM_NOT_FOUND&#x60; with &#x60;success&#x60; true: the request worked, there is no data. | 
**Error** | **string** | The error code, such as &#x60;BAD_TOKEN&#x60;. Listed in the introduction. | 
**Detail** | **string** | What went wrong, in words. | 
**Data** | **Object** | Extra data for some errors, usually null. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# TorBox.Sdk.Model.AddToDropbox

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | Id of the torrent, usenet download or web download. Still required by the route, but no longer used. | 
**DropboxToken** | **string** | Dropbox OAuth access token. Still required by the route, but no longer used. | 
**FileId** | **long** | Id of the file inside the download. No longer used. | [optional] 
**Zip** | **bool** | Whether to upload the whole download as one zip. No longer used. | [optional] [default to false]
**Type** | **string** | Which kind of download &#x60;id&#x60; refers to. One of &#x60;torrent&#x60;, &#x60;usenet&#x60; or &#x60;webdownload&#x60;. Optional, default &#x60;torrent&#x60;. Still checked before the route answers. | [optional] [default to "torrent"]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


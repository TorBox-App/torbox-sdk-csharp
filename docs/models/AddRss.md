# TorBox.Sdk.Model.AddRss

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | URL of the rss feed you want to add. | 
**Name** | **string** | Display name of the rss feed you want to add. | 
**DoRegex** | **string** | Regex of items you want to make sure are added. Optional. | [optional] 
**DontRegex** | **string** | Regex of items you dont want added. Optional. | [optional] 
**DontOlderThan** | **long** | Time in days that tells the parser to skip if the torrent is older than that many days. Optional. | [optional] 
**PassCheck** | **bool** | Boolean which tells to allow multiple of the same url if it already exists on your account | [optional] [default to false]
**ScanInterval** | **long** | Time in minutes with the minimum being 10 which you want the api to scan in interval. Optional. Default is 60. | [optional] [default to 60]
**RssType** | **string** | The type of downloads inside of this RSS feed. Optional. Default is torrent. Options are \&quot;torrent\&quot;, \&quot;usenet\&quot;, \&quot;webdl\&quot; | [optional] [default to "torrent"]
**TorrentSeeding** | **long** | Determines if torrents inside of this RSS feed will seed or not. Optional. Default is 1, for auto. Options are 1 for auto, 2 for always, and 3 for never. | [optional] [default to 1]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


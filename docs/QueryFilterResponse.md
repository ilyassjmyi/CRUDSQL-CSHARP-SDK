# Org.OpenAPITools.Model.QueryFilterResponse
Paginated response containing filtered entities and metadata Used for both simple list operations and complex filtered queries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **Object** | @Description Array of entities matching the filter conditions @Description For relationship queries, includes related entities based on the filter | [optional] 
**Page** | **int** | @Description Current page number (1-based indexing) @Description Example: page&#x3D;2 returns the second page of results | [optional] 
**PageSize** | **int** | @Description Number of items per page (default may vary) @Description Example: page_size&#x3D;20 returns 20 items per page | [optional] 
**Total** | **int** | @Description Total number of records matching the filter conditions @Description Used for calculating pagination metadata | [optional] 
**TotalPages** | **int** | @Description Total number of pages based on total records and page size @Description Calculated as ceil(total/page_size) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


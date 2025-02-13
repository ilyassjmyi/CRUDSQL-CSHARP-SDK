# Org.OpenAPITools.Api.DynamicApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ModelFilterPost**](DynamicApi.md#modelfilterpost) | **POST** /{model}/filter | Filter entities |
| [**ModelGet**](DynamicApi.md#modelget) | **GET** /{model} | List and filter entities |
| [**ModelIdDelete**](DynamicApi.md#modeliddelete) | **DELETE** /{model}/{id} | Delete an entity |
| [**ModelIdGet**](DynamicApi.md#modelidget) | **GET** /{model}/{id} | Get an entity by ID |
| [**ModelIdPut**](DynamicApi.md#modelidput) | **PUT** /{model}/{id} | Update an entity |
| [**ModelPost**](DynamicApi.md#modelpost) | **POST** /{model} | Create a new entity |

<a id="modelfilterpost"></a>
# **ModelFilterPost**
> QueryFilterResponse ModelFilterPost (string model, QueryQueryFilter filter, int? page = null, int? pageSize = null, string? sort = null)

Filter entities

Filter entities using complex conditions including field expressions, logical operations, and relationship filtering

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelFilterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model name
            var filter = new QueryQueryFilter(); // QueryQueryFilter | Filter conditions
            var page = 1;  // int? | Page number (optional)  (default to 1)
            var pageSize = 10;  // int? | Items per page (optional)  (default to 10)
            var sort = "sort_example";  // string? | Sort field and direction (e.g., name:asc,age:desc) (optional) 

            try
            {
                // Filter entities
                QueryFilterResponse result = apiInstance.ModelFilterPost(model, filter, page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelFilterPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelFilterPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Filter entities
    ApiResponse<QueryFilterResponse> response = apiInstance.ModelFilterPostWithHttpInfo(model, filter, page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelFilterPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model name |  |
| **filter** | [**QueryQueryFilter**](QueryQueryFilter.md) | Filter conditions |  |
| **page** | **int?** | Page number | [optional] [default to 1] |
| **pageSize** | **int?** | Items per page | [optional] [default to 10] |
| **sort** | **string?** | Sort field and direction (e.g., name:asc,age:desc) | [optional]  |

### Return type

[**QueryFilterResponse**](QueryFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modelget"></a>
# **ModelGet**
> QueryFilterResponse ModelGet (string model, int? page = null, int? pageSize = null, string? sort = null)

List and filter entities

Get a list of entities. Use query parameters for simple filtering or POST to /filter for complex conditions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model Name
            var page = 56;  // int? | Page number (optional) 
            var pageSize = 56;  // int? | Items per page (optional) 
            var sort = "sort_example";  // string? | Sort field and direction (e.g., name:asc) (optional) 

            try
            {
                // List and filter entities
                QueryFilterResponse result = apiInstance.ModelGet(model, page, pageSize, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List and filter entities
    ApiResponse<QueryFilterResponse> response = apiInstance.ModelGetWithHttpInfo(model, page, pageSize, sort);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model Name |  |
| **page** | **int?** | Page number | [optional]  |
| **pageSize** | **int?** | Items per page | [optional]  |
| **sort** | **string?** | Sort field and direction (e.g., name:asc) | [optional]  |

### Return type

[**QueryFilterResponse**](QueryFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modeliddelete"></a>
# **ModelIdDelete**
> ApiErrorResponse ModelIdDelete (string model, string id)

Delete an entity

Delete an entity by its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model Name
            var id = "id_example";  // string | Entity ID

            try
            {
                // Delete an entity
                ApiErrorResponse result = apiInstance.ModelIdDelete(model, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an entity
    ApiResponse<ApiErrorResponse> response = apiInstance.ModelIdDeleteWithHttpInfo(model, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model Name |  |
| **id** | **string** | Entity ID |  |

### Return type

[**ApiErrorResponse**](ApiErrorResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modelidget"></a>
# **ModelIdGet**
> QueryFilterResponse ModelIdGet (string model, string id)

Get an entity by ID

Retrieve a single entity by its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model Name
            var id = "id_example";  // string | Entity ID

            try
            {
                // Get an entity by ID
                QueryFilterResponse result = apiInstance.ModelIdGet(model, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an entity by ID
    ApiResponse<QueryFilterResponse> response = apiInstance.ModelIdGetWithHttpInfo(model, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model Name |  |
| **id** | **string** | Entity ID |  |

### Return type

[**QueryFilterResponse**](QueryFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modelidput"></a>
# **ModelIdPut**
> QueryFilterResponse ModelIdPut (string model, string id, QueryEntityWithRelations entity)

Update an entity

Update an existing entity by its ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model Name
            var id = "id_example";  // string | Entity ID
            var entity = new QueryEntityWithRelations(); // QueryEntityWithRelations | Entity Data

            try
            {
                // Update an entity
                QueryFilterResponse result = apiInstance.ModelIdPut(model, id, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an entity
    ApiResponse<QueryFilterResponse> response = apiInstance.ModelIdPutWithHttpInfo(model, id, entity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model Name |  |
| **id** | **string** | Entity ID |  |
| **entity** | [**QueryEntityWithRelations**](QueryEntityWithRelations.md) | Entity Data |  |

### Return type

[**QueryFilterResponse**](QueryFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="modelpost"></a>
# **ModelPost**
> QueryFilterResponse ModelPost (string model, QueryEntityWithRelations entity)

Create a new entity

Create a new entity of the specified model type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new DynamicApi(config);
            var model = "model_example";  // string | Model Name
            var entity = new QueryEntityWithRelations(); // QueryEntityWithRelations | Entity Data

            try
            {
                // Create a new entity
                QueryFilterResponse result = apiInstance.ModelPost(model, entity);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DynamicApi.ModelPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new entity
    ApiResponse<QueryFilterResponse> response = apiInstance.ModelPostWithHttpInfo(model, entity);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DynamicApi.ModelPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model Name |  |
| **entity** | [**QueryEntityWithRelations**](QueryEntityWithRelations.md) | Entity Data |  |

### Return type

[**QueryFilterResponse**](QueryFilterResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


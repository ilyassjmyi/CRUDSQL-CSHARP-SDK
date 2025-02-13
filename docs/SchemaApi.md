# Org.OpenAPITools.Api.SchemaApi

All URIs are relative to */api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ModelSchemaGet**](SchemaApi.md#modelschemaget) | **GET** /{model}/schema | Get model schema |

<a id="modelschemaget"></a>
# **ModelSchemaGet**
> ApiModelSchema ModelSchemaGet (string model)

Get model schema

Returns the schema information for a specific model including fields and relationships

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ModelSchemaGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api";
            var apiInstance = new SchemaApi(config);
            var model = "model_example";  // string | Model name

            try
            {
                // Get model schema
                ApiModelSchema result = apiInstance.ModelSchemaGet(model);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchemaApi.ModelSchemaGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ModelSchemaGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get model schema
    ApiResponse<ApiModelSchema> response = apiInstance.ModelSchemaGetWithHttpInfo(model);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchemaApi.ModelSchemaGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **model** | **string** | Model name |  |

### Return type

[**ApiModelSchema**](ApiModelSchema.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


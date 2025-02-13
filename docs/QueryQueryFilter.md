# Org.OpenAPITools.Model.QueryQueryFilter
Filter conditions for querying entities using complex expressions Supports logical operations (AND, OR, NOT), field comparisons, and relationship filtering Example: { \"expressions\": [ {\"field\": \"age\", \"operator\": \"gte\", \"value\": 18}, { \"operator\": \"AND\", \"expressions\": [ {\"field\": \"status\", \"operator\": \"eq\", \"value\": \"active\"} ] } ] }

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expressions** | **List&lt;Object&gt;** | @Description Array of expressions to filter entities @Description Each expression can be a FieldExpression, LogicalExpression, or RelationshipExpression | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


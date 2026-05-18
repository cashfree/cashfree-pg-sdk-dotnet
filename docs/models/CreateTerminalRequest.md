# cashfree-dotnet-pg-sdk.Model.CreateTerminalRequest
Request body to create a terminal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TerminalId** | **string** | merchant’s internal terminal id. | 
**TerminalPhoneNo** | **string** | phone number assigned to the terminal. | 
**TerminalName** | **string** | terminal name to be assigned by merchants. | 
**TerminalEmail** | **string** | terminal email ID of the AGENT/STOREFRONT assigned by merchants. | 
**TerminalType** | **string** | mention the terminal type. possible values - AGENT, STOREFRONT. | 
**TerminalAddress** | **string** | address of the terminal. required for STOREFRONT. | [optional] 
**TerminalNote** | **string** | additional note for terminal. | [optional] 
**TerminalMeta** | [**CreateTerminalRequestTerminalMeta**](CreateTerminalRequestTerminalMeta.md) |  | [optional] 
**TerminalVpaPrefix** | **string** | Merchant&#39;s vpa prefix for the terminal. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


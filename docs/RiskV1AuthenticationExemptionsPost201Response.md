# CyberSource.Model.RiskV1AuthenticationExemptionsPost201Response
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**PtsV2PaymentsReversalsPost201ResponseLinks**](PtsV2PaymentsReversalsPost201ResponseLinks.md) |  | [optional] 
**Id** | **string** | An unique identification number assigned by CyberSource to identify the submitted request. It is also appended to the endpoint of the resource. | [optional] 
**SubmitTimeUtc** | **string** | Time of request in UTC. Format: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; Example &#x60;2016-08-11T22:47:57Z&#x60; equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The &#x60;T&#x60; separates the date and the time. The &#x60;Z&#x60; indicates UTC.  | [optional] 
**Status** | **string** | The status for authentication-exemptions 201. Value is: - AUTHENTICATION_EXEMPTIONS_SUCCESSFUL  | [optional] 
**RiskInformation** | [**RiskV1AuthenticationExemptionsPost201ResponseRiskInformation**](RiskV1AuthenticationExemptionsPost201ResponseRiskInformation.md) |  | [optional] 
**ConsumerAuthenticationInformation** | [**RiskV1AuthenticationExemptionsPost201ResponseConsumerAuthenticationInformation**](RiskV1AuthenticationExemptionsPost201ResponseConsumerAuthenticationInformation.md) |  | [optional] 
**ErrorInformation** | [**PtsV2PaymentsPost201ResponseErrorInformation**](PtsV2PaymentsPost201ResponseErrorInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

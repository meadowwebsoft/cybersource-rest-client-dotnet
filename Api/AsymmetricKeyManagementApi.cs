/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAsymmetricKeyManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Create one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>InlineResponse2011</returns>
        InlineResponse2011 CreateP12Keys (CreateP12KeysRequest createP12KeysRequest);

        /// <summary>
        /// Create one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Create one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>ApiResponse of InlineResponse2011</returns>
        ApiResponse<InlineResponse2011> CreateP12KeysWithHttpInfo (CreateP12KeysRequest createP12KeysRequest);
        /// <summary>
        /// Delete one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Delete one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 DeleteBulkP12Keys (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest);

        /// <summary>
        /// Delete one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Delete one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> DeleteBulkP12KeysWithHttpInfo (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest);
        /// <summary>
        /// Retrieves PKCS#12 key details
        /// </summary>
        /// <remarks>
        /// Retrieves keys details by providing the key id.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetP12KeyDetails (string keyId);

        /// <summary>
        /// Retrieves PKCS#12 key details
        /// </summary>
        /// <remarks>
        /// Retrieves keys details by providing the key id.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> GetP12KeyDetailsWithHttpInfo (string keyId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Create one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>Task of InlineResponse2011</returns>
        System.Threading.Tasks.Task<InlineResponse2011> CreateP12KeysAsync (CreateP12KeysRequest createP12KeysRequest);

        /// <summary>
        /// Create one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Create one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2011)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2011>> CreateP12KeysAsyncWithHttpInfo (CreateP12KeysRequest createP12KeysRequest);
        /// <summary>
        /// Delete one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Delete one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> DeleteBulkP12KeysAsync (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest);

        /// <summary>
        /// Delete one or more PKCS#12 keys
        /// </summary>
        /// <remarks>
        /// &#39;Delete one or more PKCS#12 keys&#39; 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> DeleteBulkP12KeysAsyncWithHttpInfo (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest);
        /// <summary>
        /// Retrieves PKCS#12 key details
        /// </summary>
        /// <remarks>
        /// Retrieves keys details by providing the key id.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> GetP12KeyDetailsAsync (string keyId);

        /// <summary>
        /// Retrieves PKCS#12 key details
        /// </summary>
        /// <remarks>
        /// Retrieves keys details by providing the key id.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetP12KeyDetailsAsyncWithHttpInfo (string keyId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AsymmetricKeyManagementApi : IAsymmetricKeyManagementApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AsymmetricKeyManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AsymmetricKeyManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsymmetricKeyManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AsymmetricKeyManagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            this.Configuration.ApiClient.Configuration = this.Configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create one or more PKCS#12 keys &#39;Create one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>InlineResponse2011</returns>
        public InlineResponse2011 CreateP12Keys (CreateP12KeysRequest createP12KeysRequest)
        {
             ApiResponse<InlineResponse2011> localVarResponse = CreateP12KeysWithHttpInfo(createP12KeysRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create one or more PKCS#12 keys &#39;Create one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>ApiResponse of InlineResponse2011</returns>
        public ApiResponse< InlineResponse2011 > CreateP12KeysWithHttpInfo (CreateP12KeysRequest createP12KeysRequest)
        {
            // verify the required parameter 'createP12KeysRequest' is set
            if (createP12KeysRequest == null)
                throw new ApiException(400, "Missing required parameter 'createP12KeysRequest' when calling AsymmetricKeyManagementApi->CreateP12Keys");

            var localVarPath = $"/kms/v2/keys-asym";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createP12KeysRequest != null && createP12KeysRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createP12KeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createP12KeysRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateP12Keys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2011))); // Return statement
        }

        /// <summary>
        /// Create one or more PKCS#12 keys &#39;Create one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>Task of InlineResponse2011</returns>
        public async System.Threading.Tasks.Task<InlineResponse2011> CreateP12KeysAsync (CreateP12KeysRequest createP12KeysRequest)
        {
             ApiResponse<InlineResponse2011> localVarResponse = await CreateP12KeysAsyncWithHttpInfo(createP12KeysRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create one or more PKCS#12 keys &#39;Create one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createP12KeysRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2011)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2011>> CreateP12KeysAsyncWithHttpInfo (CreateP12KeysRequest createP12KeysRequest)
        {
            // verify the required parameter 'createP12KeysRequest' is set
            if (createP12KeysRequest == null)
                throw new ApiException(400, "Missing required parameter 'createP12KeysRequest' when calling AsymmetricKeyManagementApi->CreateP12Keys");

            var localVarPath = $"/kms/v2/keys-asym";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (createP12KeysRequest != null && createP12KeysRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(createP12KeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = createP12KeysRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateP12Keys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2011>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2011) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2011))); // Return statement
        }

        /// <summary>
        /// Delete one or more PKCS#12 keys &#39;Delete one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 DeleteBulkP12Keys (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest)
        {
             ApiResponse<InlineResponse2003> localVarResponse = DeleteBulkP12KeysWithHttpInfo(deleteBulkP12KeysRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete one or more PKCS#12 keys &#39;Delete one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > DeleteBulkP12KeysWithHttpInfo (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest)
        {
            // verify the required parameter 'deleteBulkP12KeysRequest' is set
            if (deleteBulkP12KeysRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteBulkP12KeysRequest' when calling AsymmetricKeyManagementApi->DeleteBulkP12Keys");

            var localVarPath = $"/kms/v2/keys-asym/deletes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deleteBulkP12KeysRequest != null && deleteBulkP12KeysRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(deleteBulkP12KeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deleteBulkP12KeysRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteBulkP12Keys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003))); // Return statement
        }

        /// <summary>
        /// Delete one or more PKCS#12 keys &#39;Delete one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> DeleteBulkP12KeysAsync (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest)
        {
             ApiResponse<InlineResponse2003> localVarResponse = await DeleteBulkP12KeysAsyncWithHttpInfo(deleteBulkP12KeysRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete one or more PKCS#12 keys &#39;Delete one or more PKCS#12 keys&#39; 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deleteBulkP12KeysRequest"></param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> DeleteBulkP12KeysAsyncWithHttpInfo (DeleteBulkP12KeysRequest deleteBulkP12KeysRequest)
        {
            // verify the required parameter 'deleteBulkP12KeysRequest' is set
            if (deleteBulkP12KeysRequest == null)
                throw new ApiException(400, "Missing required parameter 'deleteBulkP12KeysRequest' when calling AsymmetricKeyManagementApi->DeleteBulkP12Keys");

            var localVarPath = $"/kms/v2/keys-asym/deletes";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (deleteBulkP12KeysRequest != null && deleteBulkP12KeysRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(deleteBulkP12KeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = deleteBulkP12KeysRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteBulkP12Keys", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2003) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003))); // Return statement
        }

        /// <summary>
        /// Retrieves PKCS#12 key details Retrieves keys details by providing the key id.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 GetP12KeyDetails (string keyId)
        {
             ApiResponse<InlineResponse2002> localVarResponse = GetP12KeyDetailsWithHttpInfo(keyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves PKCS#12 key details Retrieves keys details by providing the key id.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > GetP12KeyDetailsWithHttpInfo (string keyId)
        {
            // verify the required parameter 'keyId' is set
            if (keyId == null)
                throw new ApiException(400, "Missing required parameter 'keyId' when calling AsymmetricKeyManagementApi->GetP12KeyDetails");

            var localVarPath = $"/kms/v2/keys-asym/{keyId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (keyId != null) localVarPathParams.Add("keyId", Configuration.ApiClient.ParameterToString(keyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetP12KeyDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002))); // Return statement
        }

        /// <summary>
        /// Retrieves PKCS#12 key details Retrieves keys details by providing the key id.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> GetP12KeyDetailsAsync (string keyId)
        {
             ApiResponse<InlineResponse2002> localVarResponse = await GetP12KeyDetailsAsyncWithHttpInfo(keyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves PKCS#12 key details Retrieves keys details by providing the key id.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetP12KeyDetailsAsyncWithHttpInfo (string keyId)
        {
            // verify the required parameter 'keyId' is set
            if (keyId == null)
                throw new ApiException(400, "Missing required parameter 'keyId' when calling AsymmetricKeyManagementApi->GetP12KeyDetails");

            var localVarPath = $"/kms/v2/keys-asym/{keyId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (keyId != null) localVarPathParams.Add("keyId", Configuration.ApiClient.ParameterToString(keyId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetP12KeyDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2002) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002))); // Return statement
        }

    }
}
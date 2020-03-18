// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Search.Models;

namespace Azure.Search
{
    internal partial class IndexesClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal IndexesRestClient RestClient { get; }
        /// <summary> Initializes a new instance of IndexesClient for mocking. </summary>
        protected IndexesClient()
        {
        }
        /// <summary> Initializes a new instance of IndexesClient. </summary>
        internal IndexesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string ApiVersion = "2019-05-06-Preview")
        {
            RestClient = new IndexesRestClient(clientDiagnostics, pipeline, endpoint, ApiVersion);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Creates a new search index. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SearchIndex>> CreateAsync(Guid? xMsClientRequestId, SearchIndex index, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(xMsClientRequestId, index, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new search index. </summary>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SearchIndex> Create(Guid? xMsClientRequestId, SearchIndex index, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(xMsClientRequestId, index, cancellationToken);
        }

        /// <summary> Lists all indexes available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListIndexesResult>> ListAsync(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.ListAsync(select, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all indexes available for a search service. </summary>
        /// <param name="select"> Selects which top-level properties of the data sources to retrieve. Specified as a comma-separated list of JSON property names, or &apos;*&apos; for all properties. The default is all properties. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListIndexesResult> List(string select, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.List(select, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Creates a new search index or updates an index if it already exists. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="allowIndexDowntime"> Allows new analyzers, tokenizers, token filters, or char filters to be added to an index by taking the index offline for at least a few seconds. This temporarily causes indexing and query requests to fail. Performance and write availability of the index can be impaired for several minutes after the index is updated, or longer for very large indexes. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SearchIndex>> CreateOrUpdateAsync(string indexName, bool? allowIndexDowntime, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, SearchIndex index, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateOrUpdateAsync(indexName, allowIndexDowntime, xMsClientRequestId, ifMatch, ifNoneMatch, index, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new search index or updates an index if it already exists. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="allowIndexDowntime"> Allows new analyzers, tokenizers, token filters, or char filters to be added to an index by taking the index offline for at least a few seconds. This temporarily causes indexing and query requests to fail. Performance and write availability of the index can be impaired for several minutes after the index is updated, or longer for very large indexes. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="index"> The definition of the index to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SearchIndex> CreateOrUpdate(string indexName, bool? allowIndexDowntime, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, SearchIndex index, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateOrUpdate(indexName, allowIndexDowntime, xMsClientRequestId, ifMatch, ifNoneMatch, index, cancellationToken);
        }

        /// <summary> Deletes a search index and all the documents it contains. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string indexName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(indexName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a search index and all the documents it contains. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="ifMatch"> Defines the If-Match condition. The operation will be performed only if the ETag on the server matches this value. </param>
        /// <param name="ifNoneMatch"> Defines the If-None-Match condition. The operation will be performed only if the ETag on the server does not match this value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string indexName, Guid? xMsClientRequestId, string ifMatch, string ifNoneMatch, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(indexName, xMsClientRequestId, ifMatch, ifNoneMatch, cancellationToken);
        }

        /// <summary> Retrieves an index definition. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SearchIndex>> GetAsync(string indexName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(indexName, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves an index definition. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SearchIndex> Get(string indexName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(indexName, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Returns statistics for the given index, including a document count and storage usage. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GetIndexStatisticsResult>> GetStatisticsAsync(string indexName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetStatisticsAsync(indexName, xMsClientRequestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Returns statistics for the given index, including a document count and storage usage. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GetIndexStatisticsResult> GetStatistics(string indexName, Guid? xMsClientRequestId, CancellationToken cancellationToken = default)
        {
            return RestClient.GetStatistics(indexName, xMsClientRequestId, cancellationToken);
        }

        /// <summary> Shows how an analyzer breaks text into tokens. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="requestTodo"> The text and analyzer or analysis components to test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AnalyzeResult>> AnalyzeAsync(string indexName, Guid? xMsClientRequestId, AnalyzeRequest requestTodo, CancellationToken cancellationToken = default)
        {
            return await RestClient.AnalyzeAsync(indexName, xMsClientRequestId, requestTodo, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Shows how an analyzer breaks text into tokens. </summary>
        /// <param name="indexName"> The definition of the index to create or update. </param>
        /// <param name="xMsClientRequestId"> The tracking ID sent with the request to help with debugging. </param>
        /// <param name="requestTodo"> The text and analyzer or analysis components to test. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AnalyzeResult> Analyze(string indexName, Guid? xMsClientRequestId, AnalyzeRequest requestTodo, CancellationToken cancellationToken = default)
        {
            return RestClient.Analyze(indexName, xMsClientRequestId, requestTodo, cancellationToken);
        }
    }
}

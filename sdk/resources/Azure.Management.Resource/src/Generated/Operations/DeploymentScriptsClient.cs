// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resource.Models;

namespace Azure.Management.Resource
{
    /// <summary> The DeploymentScripts service client. </summary>
    public partial class DeploymentScriptsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DeploymentScriptsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of DeploymentScriptsClient for mocking. </summary>
        protected DeploymentScriptsClient()
        {
        }

        /// <summary> Initializes a new instance of DeploymentScriptsClient. </summary>
        public DeploymentScriptsClient(string subscriptionId, TokenCredential tokenCredential, ResourceManagementClientOptions options = null)
        {
            options ??= new ResourceManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new DeploymentScriptsRestClient(_clientDiagnostics, _pipeline, subscriptionId: subscriptionId);
        }

        /// <summary> Updates deployment script tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tags"> Resource tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentScript>> UpdateAsync(string resourceGroupName, string scriptName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateAsync(resourceGroupName, scriptName, tags, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates deployment script tags with specified values. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tags"> Resource tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentScript> Update(string resourceGroupName, string scriptName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Update(resourceGroupName, scriptName, tags, cancellationToken);
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentScript>> GetAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a deployment script with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentScript> Get(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, scriptName, cancellationToken);
        }

        /// <summary> Deletes a deployment script. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a deployment script. When operation completes, status code 200 returned without content. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(resourceGroupName, scriptName, cancellationToken);
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptLogsList>> GetLogsAsync(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetLogsAsync(resourceGroupName, scriptName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptLogsList> GetLogs(string resourceGroupName, string scriptName, CancellationToken cancellationToken = default)
        {
            return RestClient.GetLogs(resourceGroupName, scriptName, cancellationToken);
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ScriptLog>> GetLogsDefaultAsync(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetLogsDefaultAsync(resourceGroupName, scriptName, tail, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets deployment script logs for a given deployment script name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="tail"> The number of lines to show from the tail of the deployment script log. Valid value is a positive number up to 1000. If &apos;tail&apos; is not provided, all available logs are shown up to container instance log capacity of 4mb. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ScriptLog> GetLogsDefault(string resourceGroupName, string scriptName, int? tail = null, CancellationToken cancellationToken = default)
        {
            return RestClient.GetLogsDefault(resourceGroupName, scriptName, tail, cancellationToken);
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentScript> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all deployment scripts for a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentScript> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListBySubscription(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeploymentScript> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists deployments scripts. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeploymentScript> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<DeploymentScript> CreateCreate(Response originalResponse, Func<Core.HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Put, "DeploymentScriptsClient.Create", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return DeploymentScript.DeserializeDeploymentScript(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return DeploymentScript.DeserializeDeploymentScript(document.RootElement);
                }
            });
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<DeploymentScript>> StartCreateAsync(string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            var originalResponse = await RestClient.CreateAsync(resourceGroupName, scriptName, deploymentScript, cancellationToken).ConfigureAwait(false);
            return CreateCreate(originalResponse, () => RestClient.CreateCreateRequest(resourceGroupName, scriptName, deploymentScript));
        }

        /// <summary> Creates a deployment script. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="scriptName"> Name of the deployment script. </param>
        /// <param name="deploymentScript"> Deployment script supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<DeploymentScript> StartCreate(string resourceGroupName, string scriptName, DeploymentScript deploymentScript, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (scriptName == null)
            {
                throw new ArgumentNullException(nameof(scriptName));
            }
            if (deploymentScript == null)
            {
                throw new ArgumentNullException(nameof(deploymentScript));
            }

            var originalResponse = RestClient.Create(resourceGroupName, scriptName, deploymentScript, cancellationToken);
            return CreateCreate(originalResponse, () => RestClient.CreateCreateRequest(resourceGroupName, scriptName, deploymentScript));
        }
    }
}
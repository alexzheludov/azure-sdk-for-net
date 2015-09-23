// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class GlobalModelOperationsExtensions
    {
            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static User GetSubscriptionPublishingCredentials(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetSubscriptionPublishingCredentialsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetSubscriptionPublishingCredentialsAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<User> result = await operations.GetSubscriptionPublishingCredentialsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestMessage'>
            /// requestMessage with new publishing credentials
            /// </param>
            public static User UpdateSubscriptionPublishingCredentials(this IGlobalModelOperations operations, User requestMessage)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).UpdateSubscriptionPublishingCredentialsAsync(requestMessage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestMessage'>
            /// requestMessage with new publishing credentials
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> UpdateSubscriptionPublishingCredentialsAsync( this IGlobalModelOperations operations, User requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<User> result = await operations.UpdateSubscriptionPublishingCredentialsWithHttpMessagesAsync(requestMessage, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static GeoRegionCollection GetSubscriptionGeoRegions(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetSubscriptionGeoRegionsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GeoRegionCollection> GetSubscriptionGeoRegionsAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<GeoRegionCollection> result = await operations.GetSubscriptionGeoRegionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='detailed'>
            /// False to return a subset of App Service Plan properties, true to return
            /// all of the properties.
            /// Retrieval of all properties may increase the API latency.
            /// </param>
            public static ServerFarmCollection GetAllServerFarms(this IGlobalModelOperations operations, bool? detailed = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetAllServerFarmsAsync(detailed), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='detailed'>
            /// False to return a subset of App Service Plan properties, true to return
            /// all of the properties.
            /// Retrieval of all properties may increase the API latency.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerFarmCollection> GetAllServerFarmsAsync( this IGlobalModelOperations operations, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ServerFarmCollection> result = await operations.GetAllServerFarmsWithHttpMessagesAsync(detailed, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='detailed'>
            /// False to return a subset of App Service Plan properties, true to return
            /// all of the properties.
            /// Retrieval of all properties may increase the API latency.
            /// </param>
            public static ServerFarmCollection GetAllWebHostingPlans(this IGlobalModelOperations operations, bool? detailed = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetAllWebHostingPlansAsync(detailed), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='detailed'>
            /// False to return a subset of App Service Plan properties, true to return
            /// all of the properties.
            /// Retrieval of all properties may increase the API latency.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerFarmCollection> GetAllWebHostingPlansAsync( this IGlobalModelOperations operations, bool? detailed = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ServerFarmCollection> result = await operations.GetAllWebHostingPlansWithHttpMessagesAsync(detailed, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SiteCollection GetAllSites(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetAllSitesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SiteCollection> GetAllSitesAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SiteCollection> result = await operations.GetAllSitesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static HostingEnvironmentCollection GetAllHostingEnvironments(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetAllHostingEnvironmentsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<HostingEnvironmentCollection> GetAllHostingEnvironmentsAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<HostingEnvironmentCollection> result = await operations.GetAllHostingEnvironmentsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ClassicMobileServiceCollection GetAllClassicMobileServices(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).GetAllClassicMobileServicesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClassicMobileServiceCollection> GetAllClassicMobileServicesAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ClassicMobileServiceCollection> result = await operations.GetAllClassicMobileServicesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object ListPremierAddOnOffers(this IGlobalModelOperations operations)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).ListPremierAddOnOffersAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ListPremierAddOnOffersAsync( this IGlobalModelOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<object> result = await operations.ListPremierAddOnOffersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Hosting environment name
            /// </param>
            public static object IsHostingEnvironmentNameAvailable(this IGlobalModelOperations operations, string name)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).IsHostingEnvironmentNameAvailableAsync(name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Hosting environment name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsHostingEnvironmentNameAvailableAsync( this IGlobalModelOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<object> result = await operations.IsHostingEnvironmentNameAvailableWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Hosting environment name
            /// </param>
            public static object IsHostingEnvironmentWithLegacyNameAvailable(this IGlobalModelOperations operations, string name)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).IsHostingEnvironmentWithLegacyNameAvailableAsync(name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Hosting environment name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsHostingEnvironmentWithLegacyNameAvailableAsync( this IGlobalModelOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<object> result = await operations.IsHostingEnvironmentWithLegacyNameAvailableWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// Name availability request
            /// </param>
            public static ResourceNameAvailability CheckNameAvailability(this IGlobalModelOperations operations, ResourceNameAvailabilityRequest request)
            {
                return Task.Factory.StartNew(s => ((IGlobalModelOperations)s).CheckNameAvailabilityAsync(request), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='request'>
            /// Name availability request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceNameAvailability> CheckNameAvailabilityAsync( this IGlobalModelOperations operations, ResourceNameAvailabilityRequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<ResourceNameAvailability> result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(request, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}

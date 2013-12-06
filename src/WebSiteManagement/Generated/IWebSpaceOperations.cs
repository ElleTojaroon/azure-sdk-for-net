// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites
{
    /// <summary>
    /// Operations for managing web spaces beneath your subscription.
    /// </summary>
    public partial interface IWebSpaceOperations
    {
        /// <summary>
        /// Creates a source control user allowed to publish to this web space.
        /// </summary>
        /// <param name='username'>
        /// The user name.
        /// </param>
        /// <param name='password'>
        /// The user password.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Publishing User operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Publishing User operation response.
        /// </returns>
        Task<WebSpacesCreatePublishingUserResponse> CreatePublishingUserAsync(string username, string password, WebSpacesCreatePublishingUserParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve details for a specified webspace name by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167017.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Space Details operation response.
        /// </returns>
        Task<WebSpacesGetResponse> GetAsync(string webSpaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the dns suffix for this subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        Task<WebSpacesGetDnsSuffixResponse> GetDnsSuffixAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// You can list the webspaces under the current subscription by
        /// issuing a GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166961.aspx
        /// for more information)
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Web Spaces operation response.
        /// </returns>
        Task<WebSpacesListResponse> ListAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the available geo regions for this webspace.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get DNS Suffix operation response.
        /// </returns>
        Task<WebSpacesListGeoRegionsResponse> ListGeoRegionsAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Get the source control users allowed to publish to this web space.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Publishing Users operation response.
        /// </returns>
        Task<WebSpacesListPublishingUsersResponse> ListPublishingUsersAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve a list of all web sites in a web space by issuing
        /// an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236429.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Web Sites operation response.
        /// </returns>
        Task<WebSpacesListWebSitesResponse> ListWebSitesAsync(string webSpaceName, WebSiteListParameters parameters, CancellationToken cancellationToken);
    }
}

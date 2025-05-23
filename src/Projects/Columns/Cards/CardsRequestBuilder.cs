// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards
{
    /// <summary>
    /// Builds and executes requests for operations under \projects\columns\cards
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CardsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Soenneker.GitHub.OpenApiClient.projects.columns.cards.item collection</summary>
        /// <param name="position">The unique identifier of the card.</param>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder"/></returns>
        [Obsolete("")]
        public global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("card_id", position);
                return new global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the Soenneker.GitHub.OpenApiClient.projects.columns.cards.item collection</summary>
        /// <param name="position">The unique identifier of the card.</param>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("card_id", position);
                return new global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.Item.WithCard_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.CardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/cards", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Projects.Columns.Cards.CardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/cards", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618

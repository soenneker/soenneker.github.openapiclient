using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Soenneker.GitHub.OpenApiClient;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Secrets;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Secrets.Item;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.OrganizationSecrets;
using Soenneker.GitHub.ClientUtil;
using Sodium;

namespace Soenneker.GitHub.OpenApiClient.Utils;

/// <summary>
/// Utility class for managing GitHub repository secrets
/// </summary>
public class GitHubRepositoriesSecretsUtil
{
    private readonly ILogger<GitHubRepositoriesSecretsUtil> _logger;
    private readonly IGitHubOpenApiClientUtil _gitHubClientUtil;

    public GitHubRepositoriesSecretsUtil(ILogger<GitHubRepositoriesSecretsUtil> logger, IGitHubOpenApiClientUtil gitHubClientUtil)
    {
        _logger = logger;
        _gitHubClientUtil = gitHubClientUtil;
    }

    /// <summary>
    /// Gets all secrets for a repository
    /// </summary>
    public async ValueTask<List<ActionsSecret>> Get(string owner, string repo, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubClientUtil.Get(cancellationToken);
            var response = await client.Repos[owner][repo].Actions.Secrets.GetAsync(cancellationToken: cancellationToken);
            return response?.Secrets ?? new List<ActionsSecret>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting secrets for repository {Owner}/{Repo}", owner, repo);
            throw;
        }
    }

    /// <summary>
    /// Gets all organization secrets available to a repository
    /// </summary>
    public async ValueTask<List<ActionsSecret>> GetOrganization(string owner, string repo, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubClientUtil.Get(cancellationToken);
            var response = await client.Repos[owner][repo].Actions.OrganizationSecrets.GetAsync(cancellationToken: cancellationToken);
            return response?.Secrets ?? new List<ActionsSecret>();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting organization secrets for repository {Owner}/{Repo}", owner, repo);
            throw;
        }
    }

    /// <summary>
    /// Gets a specific secret from a repository
    /// </summary>
    public async ValueTask<ActionsSecret> Get(string owner, string repo, string name, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubClientUtil.Get(cancellationToken);
            return await client.Repos[owner][repo].Actions.Secrets[name].GetAsync(cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting secret {Name} for repository {Owner}/{Repo}", name, owner, repo);
            throw;
        }
    }

    /// <summary>
    /// Gets the public key for a repository
    /// </summary>
    public async ValueTask<(string KeyId, string Key)> GetPublicKey(string owner, string repo, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubClientUtil.Get(cancellationToken);
            var response = await client.Repos[owner][repo].Actions.Secrets.PublicKey.GetAsync(cancellationToken: cancellationToken);
            return (response.KeyId, response.Key);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting public key for repository {Owner}/{Repo}", owner, repo);
            throw;
        }
    }

    /// <summary>
    /// Creates or updates a secret in a repository
    /// </summary>
    public async ValueTask CreateOrUpdate(string owner, string repo, string name, string value, CancellationToken cancellationToken = default)
    {
        try
        {
            var (keyId, publicKey) = await GetPublicKey(owner, repo, cancellationToken);
            
            // Convert the base64 public key to bytes
            var publicKeyBytes = Convert.FromBase64String(publicKey);
            
            // Encrypt the secret value using libsodium
            var encryptedBytes = SealedPublicKeyBox.Create(
                System.Text.Encoding.UTF8.GetBytes(value),
                publicKeyBytes
            );
            
            // Convert the encrypted bytes to base64
            var encryptedValue = Convert.ToBase64String(encryptedBytes);

            var client = await _gitHubClientUtil.Get(cancellationToken);
            var requestBody = new WithSecret_namePutRequestBody
            {
                EncryptedValue = encryptedValue,
                KeyId = keyId
            };
            await client.Repos[owner][repo].Actions.Secrets[name].PutAsync(requestBody, cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating/updating secret {Name} for repository {Owner}/{Repo}", name, owner, repo);
            throw;
        }
    }

    /// <summary>
    /// Deletes a secret from a repository
    /// </summary>
    public async ValueTask Delete(string owner, string repo, string name, CancellationToken cancellationToken = default)
    {
        try
        {
            var client = await _gitHubClientUtil.Get(cancellationToken);
            await client.Repos[owner][repo].Actions.Secrets[name].DeleteAsync(cancellationToken: cancellationToken);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting secret {Name} for repository {Owner}/{Repo}", name, owner, repo);
            throw;
        }
    }
} 
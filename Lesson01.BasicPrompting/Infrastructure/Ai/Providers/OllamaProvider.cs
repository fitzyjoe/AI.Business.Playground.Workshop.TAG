using Lesson01.BasicPrompting.Features.Models.Execute;
using OllamaSharp;
using OllamaSharp.Models.Chat;
using System.Text;
using Microsoft.Extensions.Options;

namespace Lesson01.BasicPrompting.Infrastructure.Ai.Providers;

public sealed class OllamaProvider : IAiProvider
{
	private readonly OllamaApiClient _ollama;

	public OllamaProvider(HttpClient httpClient, IOptions<OllamaOptions> options)
	{
		httpClient.BaseAddress = new Uri(options.Value.Endpoint);
		_ollama = new OllamaApiClient(httpClient)
		{
			SelectedModel = options.Value.Model
		};
	}
	
	public async Task<AiResponse> SendAsync(
		AiRequest aiRequest,
		CancellationToken cancellationToken = default)
	{
		await Task.Yield();
		throw new NotImplementedException("WORKSHOP: send the prompt to Ollama and build AiResponse.");
	}
}

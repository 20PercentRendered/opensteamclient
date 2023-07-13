namespace Common.Extensions;

public static class HttpClientExtensions
{
    public static async Task DownloadAsync(this HttpClient client, string requestUri, Stream destination, IProgress<int> progress, long knownLength = 0, CancellationToken cancellationToken = default)
    {
        // Get the http headers first to examine the content length
        using (var response = await client.GetAsync(requestUri, HttpCompletionOption.ResponseHeadersRead))
        {
            long contentLength = 0;
            if (knownLength > 0) {
                contentLength = knownLength;
            } else if (response.Content.Headers.ContentLength != null) {
                contentLength = (long)response.Content.Headers.ContentLength;
            }

            using (var download = await response.Content.ReadAsStreamAsync())
            {

                // Ignore progress reporting when no progress reporter was 
                // passed or when the content length is unknown
                if (progress == null || contentLength == 0)
                {
                    await download.CopyToAsync(destination);
                    return;
                }

                // Convert absolute progress (bytes downloaded) into relative progress (0% - 100%)
                var relativeProgress = new Progress<long>(totalBytes => progress.Report((int)(((float)totalBytes / contentLength)*100)));

                // Use extension method to report progress while downloading
                await download.CopyToAsync(destination, 81920, relativeProgress, cancellationToken);

                progress.Report(100);
            }
        }
    }
}
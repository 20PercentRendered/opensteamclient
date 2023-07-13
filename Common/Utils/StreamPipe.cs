namespace Common.Utils;

public class StreamPiper {
    
}
public class StreamPiper<TSource, TDest> 
where TSource : Stream
where TDest : Stream
{
    public TSource Source { get; protected set; }
    public TDest Destination { get; protected set; }
    private Task? worker;

    bool shouldRun = true;
    bool stopped = false;
    bool hasWritten = false;

    public event EventHandler? StreamPositionChanged;

    private StreamPiper(TSource source, TDest destination)
    {
        Source = source;
        Destination = destination;
    }

    public static StreamPiper<TSource, TDest> StartPiping(TSource source, TDest destination)
    {
        StreamPiper<TSource, TDest> pipe = new StreamPiper<TSource, TDest>(source, destination);
        pipe.worker = Task.Run(async () =>
        {
            byte[] buffer = new byte[4096];
            while (pipe.shouldRun)
            {
                if (pipe.Destination.CanWrite && pipe.Source.CanRead)
                {
                    var count = await pipe.Source.ReadAsync(buffer, 0, 4096);
                    pipe.StreamPositionChanged?.Invoke(pipe, EventArgs.Empty);

                    if (count > 0)
                    {
                        await pipe.Destination.WriteAsync(buffer, 0, count);
                        await pipe.Destination.FlushAsync();

                        pipe.hasWritten = true;

                        if (!pipe.shouldRun)
                        {
                            pipe.stopped = true;
                        }
                    }
                } else if (pipe.hasWritten) {
                    // If the pipe closes afterwards, stop piping.
                    Console.WriteLine("Closed");
                    pipe.StopPiping();
                }
            }
        });
        return pipe;
    }

    public void StopPiping()
    {
        shouldRun = false;
        do
        {
            Thread.Sleep(10);
        } while (!this.stopped);
    }
}
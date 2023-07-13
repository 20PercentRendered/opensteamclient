namespace Common.Utils;

public interface IExtendedProgress<T> : IProgress<T>
{
    public bool Throbber { get; }
    public T Progress { get; }
    public T MaxProgress { get; }
    public string Operation { get; }
    public string SubOperation { get; }
    public void SetThrobber(bool value);
    public void SetProgress(T value);
    public void SetMaxProgress(T value);
    public void SetOperation(string value);
    public void SetSubOperation(string value);
    public void FinishOperation(string? message = null);
}
public class ExtendedProgress<T> : IExtendedProgress<T>
{
    /// <summary>
    /// A throbber is a progressbar that doesn't have a set max value.
    /// It is used to inform users that an operation is ongoing, but it's progression is not known.
    /// </summary>
    public bool Throbber { get; private set; }
    public T InitialProgress { get; private set; }
    public T Progress { get; private set; }
    public T MaxProgress { get; private set; }
    public string Operation { get; private set; }
    public string SubOperation { get; private set; }

    public event EventHandler<T>? ProgressChanged;
    public event EventHandler<string?>? OperationFinished;
    public object PropertyLock = new object();
    public object SendLock = new object();

    private static SynchronizationContext defaultSyncContext = new SynchronizationContext();

    private readonly SynchronizationContext synchronizationContext;
    /// <summary>A cached delegate used to post invocation to the synchronization context.</summary>
    private readonly SendOrPostCallback invokeHandlers;

    public ExtendedProgress(T initialProgress, T maxProgress)
    {
        synchronizationContext = SynchronizationContext.Current ?? defaultSyncContext;
        Operation = "";
        SubOperation = "";
        Throbber = false;
        this.InitialProgress = initialProgress;
        Progress = initialProgress;
        MaxProgress = maxProgress;
        this.invokeHandlers = new SendOrPostCallback(InvokeHandlers);
    }

    void IExtendedProgress<T>.SetThrobber(bool value) {
        lock (PropertyLock) {
            this.Throbber = value;
            (this as IProgress<T>).Report(this.InitialProgress);
        } 
    }

    void IExtendedProgress<T>.SetProgress(T value) {
        lock (PropertyLock) {
            (this as IProgress<T>).Report(value);
        }
    }
    void IExtendedProgress<T>.SetMaxProgress(T value) {
        lock (PropertyLock) {
            this.MaxProgress = value;
            (this as IProgress<T>).Report(this.Progress);
        }
    }
    void IExtendedProgress<T>.SetOperation(string value) {
        lock(PropertyLock) {
            this.Operation = value;
            this.SubOperation = "";
            (this as IProgress<T>).Report(this.InitialProgress);
        }
    }
    void IExtendedProgress<T>.SetSubOperation(string value) {
        lock(PropertyLock) {
            this.SubOperation = value;
            (this as IProgress<T>).Report(this.Progress);
        }
    }

    void IExtendedProgress<T>.FinishOperation(string? message) {
        OperationFinished?.Invoke(this, message);
    }

    void IProgress<T>.Report(T value)
    {
        // If there's no handler, don't bother going through the sync context.
        // Inside the callback, we'll need to check again, in case 
        // an event handler is removed between now and then.
        if (ProgressChanged != null)
        {
            // Post the processing to the sync context.
            // (If T is a value type, it will get boxed here.)
            synchronizationContext.Post(invokeHandlers, value);
        }
    }

    /// <summary>Invokes the action and event callbacks.</summary>
    /// <param name="state">The progress value.</param>
    private void InvokeHandlers(object? state)
    {
        lock (SendLock) {
            if (state == null) {
                return;
            }

            T value = (T)state;

            this.Progress = value;
            ProgressChanged?.Invoke(this, value);
        }
    }

}
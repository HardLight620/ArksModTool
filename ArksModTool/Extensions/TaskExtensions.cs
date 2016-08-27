using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

internal static class TaskExtensions
{
    public static bool IsCancelledEx(this Task task)
    {
        if (task.IsCanceled)
            return true;

        if (!task.IsFaulted)
            return false;

        if (task.Exception.InnerExceptions.OfType<OperationCanceledException>().Any())
            return true;

        if (task.Exception.InnerExceptions.OfType<WebException>().Any(x => x.Status == WebExceptionStatus.RequestCanceled))
            return true;

        return false;
    }

    public static Task ContinueWithThisContext(this Task task, Action<Task> continuationAction)
    {
        return task.ContinueWith(continuationAction, TaskScheduler.FromCurrentSynchronizationContext());
    }

    public static Task ContinueWithThisContext<T>(this Task<T> task, Action<Task<T>> continuationFunction)
    {
        return task.ContinueWith(continuationFunction, TaskScheduler.FromCurrentSynchronizationContext());
    }

    public static Task<T> ContinueWithThisContext<T>(this Task task, Func<Task, T> continuationFunction)
    {
        return task.ContinueWith(continuationFunction, TaskScheduler.FromCurrentSynchronizationContext());
    }

    public static Task<TNewResult> ContinueWithThisContext<TResult, TNewResult>(this Task<TResult> task, Func<Task<TResult>, TNewResult> continuationFunction)
    {
        return task.ContinueWith(continuationFunction, TaskScheduler.FromCurrentSynchronizationContext());
    }
}
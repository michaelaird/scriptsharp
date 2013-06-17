// IDeferred.cs
// Script#/Libraries/jQuery/Core
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi {

    /// <summary>
    /// Represents a deferred value.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    public interface IDeferred {

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or
        /// rejected.
        /// </summary>
        /// <param name="callbacks">The callbacsk to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Always(params Action[] callbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or
        /// rejected.
        /// </summary>
        /// <param name="callbacks">The callbacsk to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Always(params Callback[] callbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Done(params Action[] doneCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Done(params Callback[] doneCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is rejected. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Fail(params Action[] failCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is rejected. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Fail(params Callback[] failCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object generates progress notifications.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Progress(params Action[] progressCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object generates progress notifications.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Progress(params Callback[] progressCallbacks);


        /// <summary>
        /// Determine the current state of a Deferred object.
        /// </summary>
        /// <returns>The current state of the deferred object</returns>
        DeferredState State();

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected, or still in progress.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneFilter">The filter to invoke when the deferred object is resolved.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Then(jQueryDeferredFilter doneFilter);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected, or still in progress.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneFilter">The filter to invoke when the deferred object is resolved.</param>
        /// <param name="failFilter">The filter to invoke when the deferred object is rejected.</param>
        /// <param name="progressFilter">The filter to invoke when progress notifications are sent to the deferred.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred Then(jQueryDeferredFilter doneFilter, jQueryDeferredFilter failFilter, jQueryDeferredFilter progressFilter);
    }

    /// <summary>
    /// Represents a deferred value.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    public interface IDeferred<TData> {

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or
        /// rejected.
        /// </summary>
        /// <param name="callbacks">The callbacsk to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Always(params Action[] callbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or
        /// rejected.
        /// </summary>
        /// <param name="callbacks">The callbacsk to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Always(params Action<TData>[] callbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Done(params Action[] doneCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Done(params Action<TData>[] doneCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is rejected. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Fail(params Action[] failCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is rejected. If the
        /// deferred object is already resolved, the handlers are still invoked.
        /// </summary>
        /// <param name="failCallbacks">The callbacks to invoke (in order).</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Fail(params Action<TData>[] failCallbacks);

        /// <summary>
        /// Determines whether the deferred object has been rejected.
        /// </summary>
        /// <returns>true if it has been rejected; false otherwise.</returns>
        bool IsRejected();

        /// <summary>
        /// Determines whether the deferred object has been resolved.
        /// </summary>
        /// <returns>true if it has been resolved; false otherwise.</returns>
        bool IsResolved();

        /// <summary>
        /// Filters deffered objects.
        /// </summary>
        /// <param name="successFilter">The filter to invoke when the deferred object is resolved.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TTargetData> Pipe<TTargetData>(jQueryDeferredFilter<TTargetData, TData> successFilter);

        /// <summary>
        /// Filters deffered objects.
        /// </summary>
        /// <param name="successFilter">The filter to invoke when the deferred object is resolved.</param>
        /// <param name="failFilter">The filter to invoke when the deferred object is rejected.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TTargetData> Pipe<TTargetData>(jQueryDeferredFilter<TTargetData, TData> successFilter, jQueryDeferredFilter<TTargetData> failFilter);

        /// <summary>
        /// Chains deffered objects.
        /// </summary>
        /// <param name="successChain">The filter to invoke when the deferred object is resolved.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TTargetData> Pipe<TTargetData>(Func<TData, IDeferred<TTargetData>> successChain);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallback">The callback to invoke when the object is resolved.</param>
        /// <param name="failCallback">The callback to invoke when the object is rejected.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Then(Action doneCallback, Action failCallback);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallback">The callback to invoke when the object is resolved.</param>
        /// <param name="failCallback">The callback to invoke when the object is rejected.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Then(Action<TData> doneCallback, Action<TData> failCallback);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke when the object is resolved.</param>
        /// <param name="failCallbacks">The callbacks to invoke when the object is rejected.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Then(Action[] doneCallbacks, Action[] failCallbacks);

        /// <summary>
        /// Add handlers to be called when the deferred object is resolved or rejected.
        /// If the object has already been resolved or rejected, the handlers are still invoked.
        /// </summary>
        /// <param name="doneCallbacks">The callbacks to invoke when the object is resolved.</param>
        /// <param name="failCallbacks">The callbacks to invoke when the object is rejected.</param>
        /// <returns>The current deferred object.</returns>
        IDeferred<TData> Then(Action<TData>[] doneCallbacks, Action<TData>[] failCallbacks);
    }
}

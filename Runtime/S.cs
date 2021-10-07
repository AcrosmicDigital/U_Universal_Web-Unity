﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace U.Universal.Web
{
    internal static class S
    {


        internal static async Task WaitAsTask(this AsyncOperation asyncOperation)
        {
            if (Application.isPlaying)
            {
                IEnumerator Helper()
                {
                    while (!asyncOperation.isDone)
                        yield return null;
                }

                var host = new GameObject("AsyncOperation-Host");
                UnityEngine.Object.DontDestroyOnLoad(host);
                try
                {
                    await Helper().WaitAsTask(host);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    UnityEngine.Object.Destroy(host);
                }

                return;

            }

            // The Task that will wait for the coroutine
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            asyncOperation.completed += (o) => tcs.SetResult(true);

            await tcs.Task;

        }


        internal async static Task WaitAsTask(this IEnumerator iEnumerator, GameObject gameObject)
        {

            // The Task that will wait for the coroutine
            TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();

            // Exception catched from the IEnumerator
            Exception error = null;

            // Current object returned for the corroutine
            object current;


            // The IEnumerator that will help to wait for the corroutine
            IEnumerator Helper()
            {

                while (true)
                {
                    try
                    {
                        if (!iEnumerator.MoveNext())
                            break;
                        current = iEnumerator.Current;
                    }
                    catch (Exception e)
                    {
                        error = e;
                        break;
                    }

                    yield return current;
                }

                // If exceptions
                if (error != null)
                    tcs.SetException(error);
                else
                {
                    tcs.SetResult(true);
                }

                yield break;
            }


            // Is searched a monobehavior to run the coroutines
            UroutineRunner uroutineRunner = gameObject.GetComponent<UroutineRunner>();
            // Is added the MonoBehaviour to the GameObject if there is no one
            if (uroutineRunner == null)
                uroutineRunner = gameObject.AddComponent<UroutineRunner>();

            // Subscription to the listener
            uroutineRunner.OnDestroyEvent.AddListener(() =>
            {

                try
                {
                    if (!tcs.Task.IsCompleted)
                    {
                        error = new InvalidOperationException("GameObject Destroyed Before Uroutine End");
                        tcs.SetException(error);
                    }
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }

            });

            // The coroutine is started and the Task is returned
            uroutineRunner.StartCoroutine(Helper());
            await tcs.Task;

        }


        internal class UroutineRunner : MonoBehaviour
        {

            internal UnityEvent OnDestroyEvent = new UnityEvent();

            private void OnDestroy()
            {
                OnDestroyEvent?.Invoke();
            }

        }




    }

}

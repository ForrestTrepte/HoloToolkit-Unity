// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    public class OpenBrowser : MonoBehaviour
    {
        public void Launch(string url)
        {
            Debug.Log($"BrowserIntegration: Launching browser at {url}");

#if WINDOWS_UWP
        UnityEngine.WSA.Application.InvokeOnUIThread(async () =>
        {
            var uri = new System.Uri(url);
            bool result = await Windows.System.Launcher.LaunchUriAsync(uri);
            if (!result)
            {
                Debug.LogError("Browser failed to launch.");
            }
        }, false);
#else
            Application.OpenURL(url);
#endif
        }
    }
}

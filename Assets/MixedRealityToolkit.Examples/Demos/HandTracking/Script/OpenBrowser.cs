// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    public class OpenBrowser : MonoBehaviour
    {
        public void Launch(string url)
        {
            Debug.Log($"OpenBrowser: Launching browser at {url}");
            Application.OpenURL(url);
        }
    }
}

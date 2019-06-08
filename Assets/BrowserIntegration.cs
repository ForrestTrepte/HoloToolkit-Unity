using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrowserIntegration : MonoBehaviour
{
    public void Launch()
    {
        Debug.Log("BrowserIntegration.Launch");

#if WINDOWS_UWP
        UnityEngine.WSA.Application.InvokeOnUIThread(async () =>
        {
            var testAppUri = new System.Uri("http://www.microsoft.com");
            bool result = await Windows.System.Launcher.LaunchUriAsync(testAppUri);
            Debug.Log(result ? "Succeeded" : "Failed");
        }, false);
#endif
    }
}

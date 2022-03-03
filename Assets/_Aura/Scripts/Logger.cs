using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class accepts log messages from other components
/// provides a central place for log management
/// </summary>
public class Logger : MonoBehaviour
{
    [SerializeField] bool canLogMessages = false;
    public void LogDebugMessage(object message, Object sender)
    {
        if (canLogMessages == true)
        {
            Debug.Log($"Logging {message} from: {sender.ToString()}");
        }
    }
}

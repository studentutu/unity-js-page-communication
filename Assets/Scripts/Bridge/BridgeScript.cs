using UnityEngine;

/// <summary>
/// Bridge used to communicate with a page
/// </summary>
public class BridgeScript : MonoBehaviour
{
    // Reference to the UI panel to display received message.
    [SerializeField]
    private UIFromPage fromPage;

    /// <summary>
    /// Receives the message from a page.
    /// </summary>
    /// <param name="message">Message.</param>
    public void ReceiveMessageFromPage(string message)
    {
        // Display the message
        fromPage.DisplayMessage(message);
    }

    /// <summary>
    /// Sends the message to a page.
    /// </summary>
    /// <param name="message">Message.</param>
    public void SendMessageToPage(string message)
    {
        // Sends the message through JS plugin
        WebGLPluginJS.SendMessageToPage(message);
    }
}

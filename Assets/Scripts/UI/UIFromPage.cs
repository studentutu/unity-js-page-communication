using UnityEngine;
using TMPro;

/// <summary>
/// UI Panel for displaying the message.
/// </summary>
public class UIFromPage : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField messageField;

    /// <summary>
    /// Assigns the message to the message field
    /// </summary>
    /// <param name="message">Message.</param>
    public void DisplayMessage(string message)
    {
        // Assign the message
        messageField.text = message;
    }
}

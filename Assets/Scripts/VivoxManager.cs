using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VivoxUnity;
using TMPro;
using UnityEngine.SceneManagement;

public class VivoxManager : VivoxVoiceManager
{
    VivoxVoiceManager vivox;

    Client client = new Client();

    private string lobbyChannelName = string.Empty;
    private ChannelId channelId;
    private List<GameObject> messageObjPoll = new List<GameObject>();
    [SerializeField] TMP_InputField nameInputFiled;
    [SerializeField] TMP_InputField channelInputField;
    [SerializeField] GameObject messageCanvas;
    [SerializeField] GameObject loginCanvas;
    [SerializeField] ScrollRect textChatScrollRect;
    public GameObject chatConntent;
    public GameObject messageObj;
    public GameObject joinChannelPanel;
    public Button EnterButton;
    public TMP_InputField messageInputField;





    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            SubmitTextToVivox();

    }

    // Start is called before the first frame update
    void Awake()
    {
        vivox = VivoxVoiceManager.Instance;
        client.Uninitialize();
        client.Initialize();
        vivox.OnUserLoggedInEvent += LoggedIn;

        if (messageObjPoll.Count > 0)
            ClearMessageObjectPool();
        ClearOutTextFiled();
    }

    private void Vivox_OnTextMessageLogReceivedEvent(string sender, IChannelTextMessage channelTextMessage)
    {
        Debug.Log(channelTextMessage);
    }

    public void Logout_button()
    {
        vivox.Logout();

        SceneManager.LoadSceneAsync(2);
        Destroy(vivox);

    }
    public void Login()
    {
        vivox.Login(nameInputFiled.text);
    }

    private void LoggedIn()
    {
        loginCanvas.SetActive(false);
        messageCanvas.SetActive(true);
    }

    public void JoinChannel()
    {
        if (string.IsNullOrEmpty(channelInputField.text))
            return;
        lobbyChannelName = channelInputField.text;
        vivox.JoinChannel(lobbyChannelName, ChannelType.NonPositional, VivoxVoiceManager.ChatCapability.TextOnly);
        channelId = vivox.ActiveChannels.FirstOrDefault(ac => ac.Channel.Name == lobbyChannelName).Key;
        Debug.Log(string.Format($"<color=red>{channelId}</color>"));
        joinChannelPanel.SetActive(false);
        vivox.OnTextMessageLogReceivedEvent += onTextMessageLogRecivedEvent;
    }
    private void EnterKeyOnTextField()
    {
        if (!Input.GetKeyDown(KeyCode.Return))
            return;
        SubmitTextToVivox();
    }
    public void SubmitTextToVivox()
    {
        if (string.IsNullOrEmpty(messageInputField.text))
            return;
        var message = messageInputField.text.ToCharArray();
        if (message[0] == '/')
        {
            message = message.Skip(1).ToArray();
            message = DiceSimulator.Roll(new string(message)).ToCharArray();
        }
        vivox.SendTextMessage(new string(message), channelId) ;
        ClearOutTextFiled();
    }

    private void onTextMessageLogRecivedEvent(string sender, IChannelTextMessage channelTextMessage)
    {
        if (!String.IsNullOrEmpty(channelTextMessage.ApplicationStanzaNamespace))
            return;
        var newMessage = Instantiate(messageObj, chatConntent.transform);
        if (messageObjPoll.Count >= 14)
        {
            Destroy(messageObjPoll[0]);
            messageObjPoll.RemoveAt(0);
        }
        newMessage.GetComponent<Text>().text = string.Format($"<color=#3F3F3F><size=8>{sender} </size><size=5>{channelTextMessage.ReceivedTime}</size></color>\n{channelTextMessage.Message}");
        messageObjPoll.Add(newMessage);
        Debug.Log(channelTextMessage.Message);
        StartCoroutine(SendScrollRectToBottom());


    }

    private IEnumerator SendScrollRectToBottom()
    {
        yield return new WaitForEndOfFrame();
        textChatScrollRect.normalizedPosition = new Vector2(0, 0);
        yield return null;
    }

    private void ClearOutTextFiled()
    {
        messageInputField.text = string.Empty;
        messageInputField.ActivateInputField();
    }

    private void ClearMessageObjectPool()
    {
        for (int i = 0; i < messageObjPoll.Count; i++)
        {
            Destroy(messageObjPoll[i]);
        }
        messageObjPoll.Clear();
    }
}




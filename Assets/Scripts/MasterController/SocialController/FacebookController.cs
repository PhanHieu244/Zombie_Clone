using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class FacebookController : MonoBehaviour
{
    private System.Action onLoginComplete;
    private System.Action onLoginFail;

    private System.Action onShareLinkComplete;
    private System.Action onShareLinkFail;

    private System.Action onShareScreenshotComplete;
    private System.Action onShareScreenshotFail;

    private System.Action onAppInviteComplete;
    private System.Action onAppInviteFail;

    /*public string linkImageShare = "";
    public string linkImageShareLevelComplete = "";*/
    /*public string linkImageAppInvite = "";
    public string linkAppInvite = "https://fb.me/799383216863366";

    public string titleShareLink = "";
    public string descriptionShareLink = "*/

    void Start()
    {
        Master.Social.Facebook = this;
    }

    private void InitCallback()
    {
    }

    private void OnHideUnity(bool isGameShown)
    {
        /*if (!isGameShown)
        {
            // Pause the game - we will need to hide
            Time.timeScale = 0;
        }
        else
        {
            // Resume the game - we're getting focus again
            Time.timeScale = 1;
        }*/
    }

    public void Login(System.Action onComplete = null, System.Action onFail = null)
    {
        /*onLoginComplete = onComplete;
        onLoginFail = onFail;
        var perms = new List<string>() {"public_profile", "email", "user_friends"};*/
    }

    //share screenshoot
    public void ShareScreenShot(string caption, System.Action onComplete = null, System.Action onFail = null)
    {
        /*onShareScreenshotComplete = onComplete;
        onShareScreenshotFail = onFail;
        StartCoroutine(TakeScreenshotAndShare(caption));*/
    }

    private IEnumerator TakeScreenshotAndShare(string caption)
    {
        yield return new WaitForEndOfFrame();

        /*var width = Screen.width;
        var height = Screen.height;
        var tex = new Texture2D(width, height, TextureFormat.RGB24, false);
        // Read screen contents into the texture
        tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex.Apply();
        byte[] screenshot = tex.EncodeToPNG();
        var wwwForm = new WWWForm();
        wwwForm.AddBinaryData("image", screenshot, "InteractiveConsole.png");
        wwwForm.AddField("name", caption);
        Debug.Log("Finish Capture and upload screenshoot");
        //FB.API("me/photos", Facebook.Unity.HttpMethod.POST, ShareScreenShootCallback, wwwForm);*/
    }

    public void ShareLink(string link = "", string title = "", string description = "", string linkImage = "",
        System.Action onComplete = null, System.Action onFail = null)
    {
        /*onShareLinkComplete = onComplete;
        onShareLinkFail = onFail;

        if (link == "")
        {
            link = Master.instance.linkInMarket;
        }

        if (title == "")
        {
            title = titleShareLink;
        }

        if (linkImage == "")
        {
            linkImage = linkImageShare;
        }

        if (description == "")
        {
            description = descriptionShareLink;
        }*/
    }


    public void AppInvite(System.Action onComplete = null, System.Action onFail = null)
    {
        /*this.onAppInviteComplete = onComplete;
        this.onAppInviteFail = onFail;*/
    }
}
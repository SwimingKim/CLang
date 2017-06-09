using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogCaller : MonoBehaviour
{
    public string title;
    public string msg;
    private string labelText;

    string package = "com.androidsample.AndroidPlugin";

    void Start()
    {
         CallSetUnityActivity();
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 180, 400, 100), labelText);

        if (GUI.Button(new Rect(100, 100, 250, 200), "Toast"))
        {
            CallToast("HelloWorld");
        }

         if (GUI.Button(new Rect(100, 400, 250, 200), "Dialog"))
        {
            CallDialog(title, msg);
        }

    }

#if UNITY_ANDROID
    AndroidJavaObject javaObj = null;
    AndroidJavaObject GetJavaObject()
    {
        if (javaObj == null)
        {
            javaObj = new AndroidJavaObject(package);
        }
        return javaObj;
    }

    void CallSetUnityActivity()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        GetJavaObject().Call("setUnityActivity", jo);
    }

    void CallToast(string strMessage)
    {
        GetJavaObject().Call("showToast", strMessage);
    }

    void CallDialog(string title, string msg)
    {
        GetJavaObject().Call("showDialog", title, msg, this.name, "ReceiveJava");
    }

    public void ReceiveJava(string text)
    {
        Debug.Log("자바로부터의 메세지 = " + text);
    }

    #endif

}

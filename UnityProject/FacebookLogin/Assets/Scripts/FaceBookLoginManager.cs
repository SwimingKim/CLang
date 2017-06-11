using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;

public class FaceBookLoginManager : MonoBehaviour {

	void Awake()
	{
		if (!FB.IsInitialized)
		{
			FB.Init(InitCallback, OnHideUnity);
		}
		else
		{
			FB.ActivateApp();
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InitCallback()
	{
		if (FB.IsInitialized)
		{
			FB.ActivateApp();
		}
		else
		{
			Debug.Log("Failed to Initialize the Fabebook SDK");
		}
	}

	void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;
		}
	}

	public void LoginButtonClick()
	{
		var perms = new List<string>(){"public_profile", "email", "user_friends"};
		FB.LogInWithReadPermissions(perms, AuthCallback);
	}

	void AuthCallback(ILoginResult result)
	{
		if (FB.IsLoggedIn)
		{
			var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
			Debug.Log(aToken.UserId);
			foreach (string perms in aToken.Permissions)
			{
				Debug.Log(perms);
			}
		}
		else
		{
			Debug.Log("User cancelled login");
		}
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Common
{
    public int a, b;
	public virtual void CommonMethod()
	{
        Debug.Log("Common Method Call");
    }
}

public class Child1 : Common
{
	public override void CommonMethod()
	{
        base.CommonMethod();
        Debug.Log("Child1 Common Method Call");
    }
	public void Method()
	{
        base.CommonMethod();
        Debug.Log("Child1 Method Call");
    }
}

public class Child2 : Common
{
    public int c;
	public void Method()
	{
        Debug.Log("Child2 Method Call");
    }
}

public class ExtendsSample : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Child1 ch1 = new Child1();
        ch1.a = 10;
        ch1.CommonMethod();
        // ch1.Method();

        Child2 ch2 = new Child2();
        ch2.a = 10;
        ch2.c = 10;
        ch2.CommonMethod();
        // ch2.Method();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

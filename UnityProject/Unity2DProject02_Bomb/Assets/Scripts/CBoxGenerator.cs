using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CBoxGenerator : CGenerator {

    Vector2 pos;

    protected override void Start()
	{
		base.Start();

		pos = transform.position;
    }

	protected override void CreateObject()
	{
		int rand = Random.Range(0, _createPrefab.Length);
        
		GameObject gameObject = Instantiate(_createPrefab[rand], pos, Quaternion.identity);

        gameObject.transform.SetParent(transform);
    }

}

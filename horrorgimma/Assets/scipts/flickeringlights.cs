using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickeringlights : MonoBehaviour
{

	Light testLight;
	public float minWaitTime = 0.5f;
	public float maxWaitTime = 0.5f;

	void Start()
	{
		testLight = GetComponent<Light>();
		StartCoroutine(Flashing());
	}

	IEnumerator Flashing()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
			testLight.enabled = !testLight.enabled;

		}
	}
}


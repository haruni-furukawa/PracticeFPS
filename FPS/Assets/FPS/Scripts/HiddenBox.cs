using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBox : MonoBehaviour
{
	public GameObject giftItem;

	void OnTriggerEnter (Collider other)
	{
		if (giftItem != null)
		{
			GameObject item = Instantiate (giftItem, transform.position, Quaternion.identity);
			item.transform.parent = null;
		}
		Destroy (gameObject);
	}
}
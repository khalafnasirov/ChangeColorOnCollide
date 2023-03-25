using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    // Method that returns random color
    Color ChangeColor()
    {
        return new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f));
    }

    // Method is calling whenever this object touching to other object 
	private void OnCollisionEnter(Collision collision)
	{
		GetComponent<MeshRenderer>().material.color = ChangeColor();
	}
}









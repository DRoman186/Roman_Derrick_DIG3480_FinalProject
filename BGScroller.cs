using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour
{
	public float scrollSpeed;
	public float tileSizeZ;

    private bool gameOver;
	private Vector3 startPosition;

	void Start ()
	{
        gameOver = false;
		startPosition = transform.position;
	}

	void Update ()
	{
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.forward * newPosition;
        if(gameOver)
        {
            scrollSpeed = 0;
        }
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    public Sprite[] balls;
	// Use this for initialization
	void Start () {
        SpawnRandomBall();
	}
	void SpawnRandomBall()
    {
        foreach (SpriteRenderer child in GetComponentsInChildren<SpriteRenderer>())
        {
            if (child.transform == transform)
                continue;
            child.sprite = balls[Random.Range(0, 5)];
        }
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(Application.loadedLevel);
	}
}

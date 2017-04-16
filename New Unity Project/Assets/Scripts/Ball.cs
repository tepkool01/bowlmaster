using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector3 launchSpeed;
    private Rigidbody rigidBody;
    private AudioSource audioSource;

    public bool inPlay;

	// Use this for initialization
	void Start ()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        this.rigidBody.useGravity = false;
    }

    public void Launch (Vector3 velocity)
    {
        inPlay = true;

        this.rigidBody.useGravity = true;
        rigidBody.velocity = velocity;

        audioSource = this.GetComponent<AudioSource>();
        audioSource.Play();
    }
}

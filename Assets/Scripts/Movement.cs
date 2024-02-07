using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float gravity = -9.81f;
    public float speed = 10f;
    public float speedRotation = 5f;

    public CharacterController controller;

    public Light flashlight;
    private int flashlightActive = 0;

    public AudioSource audioSource;


    private void Start()
    {
        audioSource.Play();
    }
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontal * speed, gravity, vertical * speed);

        controller.Move(transform.TransformDirection(movement) * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (flashlightActive == 0)
            {
                flashlight.gameObject.SetActive(true);
                flashlightActive = 1;
            }
            else if (flashlightActive == 1)
            {
                flashlight.gameObject.SetActive(false);
                flashlightActive = 0;
            }
        }

        if (vertical <= -0.2 || vertical >= 0.2 || horizontal <= -0.2 || horizontal >= 0.2)
        {
            audioSource.mute = false;
        }
        else
        {
            audioSource.mute = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowMovment : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audioSource;

    [SerializeField] float jumpForce;
    public AudioClip jumpClip;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //play Jump sound
            audioSource.PlayOneShot(jumpClip);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        transform.Translate(3 * Time.deltaTime, 0, 0);
    }
}

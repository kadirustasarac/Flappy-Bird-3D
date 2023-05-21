using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [SerializeField] float jumpForce = 1;
    [SerializeField] float gravityForce = 1;
    [SerializeField] AudioClip jumpClip;
    Rigidbody rg;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        DuckMove();

        rg.AddForce(0,gravityForce,0);
    }

    private void DuckMove()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space Bastın :)");
            rg.velocity = Vector3.zero;
            rg.AddRelativeForce(Vector3.up * jumpForce);
            audioSource.PlayOneShot(jumpClip);
        }
    }
    private void OnTriggerExit(Collider other) {
        FindObjectOfType<Scoreboard>().AddScore();
    }
}

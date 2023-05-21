using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollusionDetect : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip lost;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Object"){
        audioSource.PlayOneShot(lost);
        TMP_Text textMesh = FindObjectOfType<TMP_Text>();
        textMesh.text = "You Lost";
        Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CreateInstances : MonoBehaviour
{
    [SerializeField] int createTime = 1;
    [SerializeField] GameObject[] engeller;
    [SerializeField] GameObject PARENT;

    // Start is called before the first frame update
    void Start()
    {
       EngelHandler(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEngel()
    {
        GameObject engel = Instantiate(engeller[Random.Range(0,engeller.Length)],transform.position,Quaternion.identity);
        engel.transform.parent = PARENT.transform;
    }
    void EngelHandler()
    {
        Invoke("EngelHandler",createTime);
        CreateEngel();
    }

}
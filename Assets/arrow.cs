using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject gamemaster;
    // Start is called before the first frame update
    void Start()
    {
        gamemaster = GameObject.Find("GameObject");
        Destroy(gameObject, 3);

    }

    // Update is called once per frame
    void Update()
    {
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

    }

}
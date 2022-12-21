using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public GameObject arrow;
    float time = 1.0f;
    float delta = 0;
    public GameObject HP;
    int a;
    GameObject gg;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("arr", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HPhit()
    {
        HP.GetComponent<Image>().fillAmount -= 0.1f;

    }

    void arr()
    {
        int a = Random.Range(-9, 9);
        Instantiate(arrow, new Vector3(a, 5, 0), Quaternion.identity);
    }


}

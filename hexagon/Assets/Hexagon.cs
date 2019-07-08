using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;
    public float shrinkSpeed = 3f;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f,360f);
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= shrinkSpeed * Time.deltaTime * Vector3.one;

        if(transform.localScale.x < .5f){
            Destroy(gameObject);
            score ++;
        }
    }
}

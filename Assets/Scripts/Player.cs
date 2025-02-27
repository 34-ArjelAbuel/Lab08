﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "score")
        {
            GameManager.instance.AddScore();
        }
        if(other.gameObject.tag == "dead")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

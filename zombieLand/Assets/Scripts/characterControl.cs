using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    Animator animation;
    float playerSpeed = 7;
    public Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        animation = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if(horizontalValue != 0 || verticalValue != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, cam.transform.rotation, .3f);
        }

        animation.SetFloat("Horizontal", horizontalValue);
        animation.SetFloat("Vertical", verticalValue);

        this.gameObject.transform.Translate(horizontalValue*playerSpeed*Time.deltaTime , 0 , verticalValue*playerSpeed*Time.deltaTime);
    }
}

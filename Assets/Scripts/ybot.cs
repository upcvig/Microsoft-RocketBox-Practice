using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ybot : MonoBehaviour
{
    Animator m_animator;
    float vel_x;
    float vel_y;
    bool isIdle = true;
    bool armLayer = false;


    // Start is called before the first frame update
    void Start()
    {
        m_animator = this.transform.gameObject.GetComponent<Animator>();
        vel_x = 0f;
        vel_y = 0f;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            RunOrStop();
        }

        if(Input.GetKey(KeyCode.W)&&!isIdle)
        {
            Debug.Log("acc");
            vel_x = vel_x + 0.05f;
            if (vel_x > 1f) vel_x = 1f;
            m_animator.SetFloat("v_x", vel_x);

        }

        if (Input.GetKey(KeyCode.S) && !isIdle)
        {
            vel_x = vel_x - 0.05f;
            if (vel_x < 0f) vel_x = 0f;
            m_animator.SetFloat("v_x", vel_x);

        }

        if (Input.GetKey(KeyCode.D) && !isIdle)
        {
            vel_y = vel_y + 0.05f;
            if (vel_y > 1f) vel_y = 1f;
            m_animator.SetFloat("v_y", vel_y);

        }

        if (Input.GetKey(KeyCode.A) && !isIdle)
        {
            vel_y = vel_y - 0.05f;
            if (vel_y < -1f) vel_y = -1f;
            m_animator.SetFloat("v_y", vel_y);

        }


        if (Input.GetKeyUp(KeyCode.L))
        {
            RunOrStop();
        }


    }

    private void ArmLayerStartOrNot()
    {
        armLayer = !armLayer;

        m_animator.SetBool("arm", armLayer);
    }
    private void RunOrStop()
    {
        
        // idle true run false
        isIdle = !isIdle;
        m_animator.SetBool("idle", isIdle);

    }
}

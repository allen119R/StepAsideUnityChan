using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemdestroy : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //�I�u�W�F�N�g��unity�����܂ł̋���
    private float deflence;
    


    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unitychan����I�u�W�F�N�g�܂ł̋���(z���W)
        this.deflence=this.unitychan.transform.position.z - this.transform.position.z;

        //unitychan����6m���ꂽ��I�u�W�F�N�g��j�󂷂�
        if(this.deflence>6)    
        {
            Destroy(this.gameObject);
        }


    }
}


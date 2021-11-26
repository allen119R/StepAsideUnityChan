using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemdestroy : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //オブジェクトとunityちゃんまでの距離
    private float deflence;
    


    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unitychanからオブジェクトまでの距離(z座標)
        this.deflence=this.unitychan.transform.position.z - this.transform.position.z;

        //unitychanから6m離れたらオブジェクトを破壊する
        if(this.deflence>6)    
        {
            Destroy(this.gameObject);
        }


    }
}


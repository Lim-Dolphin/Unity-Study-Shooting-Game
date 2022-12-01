using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //총알을 생산할 공장
    public GameObject bulletFactory;

    //총구
    public GameObject firePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //사용자가 발사 버튼을 누르면
        if(Input.GetButtonDown("Fire1"))
        {
            //총알을 만들고
            GameObject bullet = Instantiate(bulletFactory);

            //총알을 발사한다
            bullet.transform.position = firePosition.transform.position;
        }
    }
}

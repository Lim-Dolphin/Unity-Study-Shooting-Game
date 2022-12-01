using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //�Ѿ��� ������ ����
    public GameObject bulletFactory;

    //�ѱ�
    public GameObject firePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //����ڰ� �߻� ��ư�� ������
        if(Input.GetButtonDown("Fire1"))
        {
            //�Ѿ��� �����
            GameObject bullet = Instantiate(bulletFactory);

            //�Ѿ��� �߻��Ѵ�
            bullet.transform.position = firePosition.transform.position;
        }
    }
}

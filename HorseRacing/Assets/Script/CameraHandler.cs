using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    // 캠이 1등을 따라가게끔 하고 싶음
    // 필요한것
    // 1. 카메라 자체의 Transform 컴포넌트
    // 2. 경주말들의 Transform 컴포넌트 

    // 뭘 해야 하는가 ?
    // 1. 경주말들의 등수를 실시간으로 갱신
    // 2. 1등 말의 위치를 가져온다 
    // 3. 카메라의 위치를 1등 말의 위치에 특정  거리만큼 떨어트려 위치시킨다.

    Transform tr;
    public List<Transform> list_Player;
    Transform leader;
    private void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        // 1등 말 체크하는 방법 : z 축 값을 비교한다 .
        // foreach문이 돌때 그전 요소의 z축 값을 저장해두면 현재 foreach문 요소와 비교 할 수 있다 .
        float prevZ = 0;
        leader = list_Player[0];
        foreach (Transform player in list_Player)
        {
            if (player.position.z > prevZ)
            {
                leader = player;
                prevZ = player.position.z;
            }
        }
        tr.position = leader.position;
    }
}

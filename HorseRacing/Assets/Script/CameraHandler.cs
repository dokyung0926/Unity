using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    // ķ�� 1���� ���󰡰Բ� �ϰ� ����
    // �ʿ��Ѱ�
    // 1. ī�޶� ��ü�� Transform ������Ʈ
    // 2. ���ָ����� Transform ������Ʈ 

    // �� �ؾ� �ϴ°� ?
    // 1. ���ָ����� ����� �ǽð����� ����
    // 2. 1�� ���� ��ġ�� �����´� 
    // 3. ī�޶��� ��ġ�� 1�� ���� ��ġ�� Ư��  �Ÿ���ŭ ����Ʈ�� ��ġ��Ų��.

    Transform tr;
    public List<Transform> list_Player;
    Transform leader;
    private void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
    }

    private void Update()
    {
        // 1�� �� üũ�ϴ� ��� : z �� ���� ���Ѵ� .
        // foreach���� ���� ���� ����� z�� ���� �����صθ� ���� foreach�� ��ҿ� �� �� �� �ִ� .
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

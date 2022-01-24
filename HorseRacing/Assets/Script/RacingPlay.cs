using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingPlay : MonoBehaviour
{
    public List<GameObject> list_Player = new List<GameObject>(); // �÷��̾ ���� ����Ʈ 
    public float minSpeed = 0; // ���� �ӵ� ���� �ּҰ�
    public float maxSpeed = 10; // ���� �ӵ� ���� �ּҰ�
    public Transform goalLine;
    public Transform platform1Grade;
    public Transform platform2Grade;
    public Transform platform3Grade;


    List<GameObject> list_Finished = new List<GameObject> (); // ���� �÷��̾�� ������ ����Ʈ
    bool isRacingFinished = false; // ���� �������� üũ�� ����

    private void Update()
    {
        // ���ְ� �ȳ������� ~
        if (isRacingFinished == false) 
        {
            GameObject tmpFinishedPlayer = null;
            // �÷��̾� ����Ʈ �ݺ�
            foreach (GameObject Player in list_Player)
            {
                float moveSpeed = Random.Range(minSpeed, maxSpeed); // �ּ�~�ִ밪���� �������� �ӵ� �����ϴ� �Լ�
                Transform tmpTr = Player.GetComponent<Transform>(); // ���� �÷��̾��� Transform ������Ʈ�� ������
                float moveDistance = moveSpeed * Time.deltaTime; // �ӵ��� ��ŸŸ�� ���ؼ� �Ÿ���� + ������ �� ���̿� ���� �̵��Ÿ� ���� ����
                Vector3 moveVector = Vector3.forward * moveDistance; // forward�������Ϳ� �̵��� �Ÿ� ���Ͽ� �̵��� ���͸� ����  
                tmpTr.Translate(moveVector);  // �̵��� ���͸�ŭ �̵� �϶�� ���

                // ����� �Ѿ����� ~
                if (tmpTr.position.z > goalLine.position.z)
                {
                    list_Finished.Add(Player);
                    list_Player.Remove(Player);
                }
            }
            list_Player.Remove(tmpFinishedPlayer);

            // �÷��̾� 5���� ��� �������� ~
            if (list_Finished.Count >= 5)
            {
                isRacingFinished = true;
                list_Finished[0].GetComponent<Transform>().position = platform1Grade.position;
                list_Finished[1].GetComponent<Transform>().position = platform2Grade.position;
                list_Finished[2].GetComponent<Transform>().position = platform3Grade.position;
            }
        }
    }
}


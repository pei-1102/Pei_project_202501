using UnityEngine;

public class Practice_5_Selection : MonoBehaviour
{
    [SerializeField, Header("��q"), Range(0, 100)]
    private float hp = 100;

    private void Update()
    {
        switch (hp)
        {
            case >= 80:
                Debug.Log("<color=#68f>��q�w��</color>");
                break;
            case >= 60:
                Debug.Log("<color=#3f3>���d���A�����p</color>");
                break;
            case >= 40:
                Debug.Log("<color=#f39>ĵ�i�A�ֳܤ�</color>");
                break;
            case >= 10:
                Debug.Log("<color=#f33>�֦����F</color>");
                break;
            case >= 0:
                Debug.Log("<color=#f11>�w�g���F</color>");
                break;
            default:
                break; 

        }
    }


}

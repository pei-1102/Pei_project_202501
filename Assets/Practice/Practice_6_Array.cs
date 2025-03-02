using UnityEngine;

public class Practice_6_Array : MonoBehaviour
{
    private string[,,] characterName =
    {
        {{"�֥d�C","�p�C","�p���s"}, {"����ؤl","�P��","�y�֥�" } },
        {{"�짯","��ۣۣ","ۣۣ�_��"}, {"���_","�Ť��F","��ۣۣ" } },
        {{"���Y�H","����","���"}, {"�Ʈ洵","�\��","�p�k�v" } },
    };
    private void Awake()
    {
        Debug.Log($"<color=#f6a>�֥d�C:{characterName[0, 0, 0]}</color>");
        Debug.Log($"<color=#f6a>ۣۣ�_��:{characterName[1, 0, 2]}</color>");
        Debug.Log($"<color=#f6a>�\��:{characterName[2, 1, 1]}</color>");

        Debug.Log($"<color=#f6a>�ĤG���ĤG�ƲĤT��:{characterName[1, 1, 2]}</color>");
    }
}

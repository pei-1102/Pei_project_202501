using UnityEngine;

namespace KID
{
    /// <summary>
    /// �R�A Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {
        // �D�R�A�ܼ�
        public int inventoryWater = 10;
        // �R�A�ܼơG�׹����L���K�[����r static
        // �R�A�ܼƤ���ܦb�ݩʭ��O�W
        public static int inventoryProp = 20;

        private void Awake()
        {
            inventoryWater = 7;
            inventoryProp = 15;
            Debug.Log($"<Color=#f31>�Ĥ�:{inventoryWater}</color>");
            Debug.Log($"<Color=#f31>�D��:{inventoryProp}</color>");
        }
    }
}

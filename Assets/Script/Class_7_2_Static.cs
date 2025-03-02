using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace KID
{
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class Class_7_2_Static : MonoBehaviour
    {

        //成員:
        // 變數、屬性、方法


        // 非靜態變數
        public int inventoryWater = 10;
        // 靜態變數：修飾詞微面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上
        public static int inventoryProp = 20;

        // 非靜態屬性
        public string skillMain => "火球術";
        // 靜態屬性
        public static string skillSecond => "治癒術";

        private float attack = 10;
        private static float mp = 100;

        private void Awake()
        {
            // inventoryWater = 7;
            // inventoryProp = 15;
            Debug.Log($"<Color=#f31>藥水:{inventoryWater}</color>");
            Debug.Log($"<Color=#f31>道具:{inventoryProp}</color>");
        }

        public void Punch()
        {
            Debug.Log("<color=#3f3>使用拳擊</color>");
            // 非靜態方法內可以存取所有成員
            Debug.Log($"<color=#f99>非靜態攻擊力{attack}</color>");
            Debug.Log($"<color=#f99>靜態魔力{mp}</color>");
        }

        public static void Kick()
        {
            Debug.Log("<color=#3f3>使用踢擊</color>");
            // 靜態方法內只內存取靜態成員
            // 由於 attack 是非靜態所以無法存取(導致錯誤)
            // Debug.Log($"<color=#f9e>非靜態攻擊力{attack}</color>");
            Debug.Log($"<color=#f99>靜態魔力{mp}</color>");
        }

        private void Start()
        {
            // 在 Unity 內的差異
            // 場景切換時
            // 非靜態成員
            inventoryWater++;    // 藥水加一
            Debug.Log($"<color=#9ff>藥水:{inventoryWater}</color>");
            inventoryProp++;     // 道具加一
            Debug.Log($"<color=#9ff>道具:{inventoryProp}</color>");

        }
        private void Update()
        {
            // 在Game 畫面按下數字1 會重新載入場景(切為英文輸入法)
            // 如果按下數字1(左邊鍵盤ㄅ)
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }
        }
    }
}

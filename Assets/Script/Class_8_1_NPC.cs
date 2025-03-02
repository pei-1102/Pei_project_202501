using UnityEngine;

namespace KID
{
    /// <summary>
    /// NPC 
    /// 類別：NPC 名稱與對話內容資料，有輸出 NPC 名稱
    /// </summary>
    public class Class_8_1_NPC
    {
        private string name;
        private string dialogue;

        // 建構子：沒有傳回類型，名稱與類別相同的公開方法
        // 預設建構子：沒有參數

        public Class_8_1_NPC()
        {
            Debug.Log("<color=#f63>預設建構子：</color>");
        }

        public Class_8_1_NPC(string _name)
        {
            name = _name;
            Debug.Log("<color=#f63>有參數的建構子：</color>");
        }

        public void LogName()
        {
            Debug.Log($"<color=#373>NPC的名稱：{name}</color>");

        }

        public void Talk()
        {
            Debug.Log($"<color=#373>NPC的名稱：{dialogue}</color>");

        }

    }

}


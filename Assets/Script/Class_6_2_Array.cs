using UnityEngine;


namespace KID
{
    public class Class_6_2_Array : MonoBehaviour
    {
        //皮卡丘、小火龍、卡比獸
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        // 陣列：用來儲存多筆相同類型的資料
        // 第一種：不指定值，透過 Unity 面板輸入
        // 修飾詞 資料類型[] 陣列名稱;
        public string[] cards;
        // 第二種：直接定義陣列的數量
        // 定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        // 第二種：直接定義陣列的值
        public string[] deck2 = { "急凍鳥", "賭霞", "寶石海星" };

        // 二維陣列
        public string[,] invertory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };
        //  三維陣列
        public string[,,] shop =
        {
            // 第一頁
            {{"小刀", "美工刀"}, {"武士刀", "屠龍刀"} },
            // 第二頁
            {{"精靈球", "高級球"}, {"大師球", "巢穴球"} }

        };

        private void Start()
        {
            #region 一維
            // 存取陣列 Set、Get
            // Get  取得陣列的資料
            // 陣列名稱[編號]
            Debug.Log($"<color=#f32>Cards 的第三張卡片:{cards[2]}</color>");
            // 超出陣列範圍，會導致錯誤
            // 錯誤會導致當機、閃退、不符合預期的結果或者不執行下方程式
            // Debug.Log($"<color=#f32>Cards 的第三張卡片:{card1[3]}</color>");

            // Set 設定陣列的資料
            // 陣列名稱[編號] 指定 值;
            // 將寶石海星換成傑尼龜
            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f39>Cards2 的第三張卡片:{deck2[2]}</color>");
            #endregion

            #region 二維、三維
            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具：{invertory[0, 1]}</color>");

            invertory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具：{invertory[1, 1]}</color>");

            // 存取三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#f3d>第一頁第二排第二個:{shop[0, 1, 1]}</color>");
            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f30>第二頁第一排第二個:{shop[1, 0, 1]}</color>");
            #endregion

            // 獲取陣列的長度或維度
            // 一維陣列的長度：陣列名稱.Length
            Debug.Log($"<color=#f93>一維 = 牌組2 的長度:{deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維 = 道具 的長度:{invertory.Length}</color>");
            Debug.Log($"<color=#f93>三維 = 商品 的長度:{shop.Length}</color>");
            // 陣列的維度：陣列名稱.Rank
            Debug.Log($"<color=#f99>一維 = 牌組2 的維度:{deck2.Rank}</color>");
            Debug.Log($"<color=#f99>二維 = 道具 的維度:{invertory.Rank}</color>");
            Debug.Log($"<color=#f99>三維 = 商品 的維度:{shop.Rank}</color>");


        }


    }
    

}

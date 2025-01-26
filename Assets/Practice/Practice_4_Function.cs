using UnityEngine;

public class Practice_4_Function : MonoBehaviour
{
    private void Awake()
    {
    
        Debug.Log($"<color= #3f3>布林值 True :{ReturnTrue()}</color>");
        Debug.Log($"<color= #3f3>布林值 False :{ReturnFalse()}</color>");
    }


    /// <summary>
    /// 布林值 True
    /// </summary>
    /// <returns>True</returns>
    private bool ReturnTrue()
    {
        return true;
    
    }
    /// <summary>
    /// 布林值 False
    /// </summary>
    /// <returns></returns>
     private bool ReturnFalse()
    {
        return false;
    
    }

}

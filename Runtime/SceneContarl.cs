using UnityEngine;
using UnityEngine.SceneManagement;


namespace benha.tools
{

}
/// <summary>
/// 場景控制，提供場景載入和遊戲離開功能
/// </summary>
public class SceneContarl : MonoBehaviour
{
    /// <summary>
    /// 遊戲場景的載入
    /// </summary>
    /// <param name="sceneName">要載入的場景名稱</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    /// <summary>
    /// 遊戲場景的離開功能
    /// </summary>
    public void QuiteGame()
    {
        Application.Quit();
    }
}

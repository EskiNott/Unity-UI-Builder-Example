using UnityEngine;
using UnityEngine.UIElements;

public class UI : MonoBehaviour
{
    [SerializeField] private CubeController cube;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button bstart = root.Q<Button>("ButtonStart");
        Button bstop = root.Q<Button>("ButtonStop");
        Button bchange = root.Q<Button>("ButtonColor");

        bstart.clicked += () => cube.StartRotate();
        bstop.clicked += () => cube.StopRotate();
        bchange.clicked += () => cube.ChangeColor();
    }
}

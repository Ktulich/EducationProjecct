using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
[System.Serializable]
public class SceneField : MonoBehaviour
{
    [SerializeField]
    private Object m_SceneAsset;
    [SerializeField]
    private string m_SceneName = "";
    public string SceneName
    {
        get { return m_SceneName; }
    }
    public static implicit operator string(SceneField sceneField)
    {
        return sceneField.SceneName;
    }

}
#if UNITY_EDITOR
/*[CustomPropertyDrawer(typeof(SceneField))]
public class SceneFieldPropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, GUIContent.none, property);
        SerializedProperty sceneAsset = property.FindPropertyRelative("m_SceneAsset");
        SerializedProperty sceneName = property.FindPropertyRelative("m_SceneName");

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        if (sceneAsset != null)
        {
            sceneAsset.objectReferenceValue = EditorGUI.ObjectField(position, sceneAsset.objectReferenceValue, typeof(SceneAsset), false);
            if (sceneAsset.objectReferenceValue != null)
                sceneName.stringValue = (sceneAsset.objectReferenceValue as SceneAsset).name;
        }

        EditorGUI.EndProperty();
    }
}*/
#endif